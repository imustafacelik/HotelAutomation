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

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            EmptyRoomManager emptyRoomManager = new EmptyRoomManager(new EfEmptyRoomDal());
           
            foreach (var emptyRooms in emptyRoomManager.GetAll().Data)
            {
                comboBox1.Items.Add(emptyRooms.RoomName);
            }

            HotelContext db = new HotelContext();
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

           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                HotelContext db = new HotelContext();
                int x = Convert.ToInt32(textBox4.Text);
                var customer = db.Customers.Find(x);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                }
                db.SaveChanges();
                label8.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HotelContext db = new HotelContext();
            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();

        }
    }
}
