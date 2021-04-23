using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class CustomerAddForm : Form
    {
        public CustomerAddForm()
        {
            InitializeComponent();
        }
        HotelContext db = new HotelContext();
        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            EmptyRoomManager emptyRoomManager = new EmptyRoomManager(new EfEmptyRoomDal());
           
            foreach (var emptyRooms in emptyRoomManager.GetAll().Data)
            {
                comboBox1.Items.Add(emptyRooms.RoomName);
            }

            
            dataGridView1.DataSource = db;       
            dataGridView1.DataSource = db.Customers.ToList();



            label8.Visible = false;
         
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


            Customer customer = new Customer
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                StartDate = dateTimePicker1.Text,
                EndDate = dateTimePicker2.Text,
                Room = Convert.ToString(comboBox1.SelectedItem)
                
            };

            customerManager.Add(customer);

            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedItem = null;



            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            Customer customer = new Customer();

            customer.Id = Convert.ToInt32(textBox4.Text);

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Delete(customer);

            textBox4.Text = "";

            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.Id = Convert.ToInt32(textBox4.Text);
            customer.FirstName = textBox1.Text;
            customer.LastName = textBox2.Text;
            customer.Phone = textBox3.Text;
            customer.StartDate = dateTimePicker1.Text;
            customer.EndDate = dateTimePicker2.Text;
            customer.Room = Convert.ToString( comboBox1.SelectedItem);

            

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Update(customer);

            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchWord = textBox5.Text;

            var results = db.Customers.Where(c => c.FirstName.Contains(searchWord)
            || c.LastName.Contains(searchWord)
            || c.Phone.Contains(searchWord)
             );
            dataGridView1.DataSource = results.ToList();
        }
    }
}
