using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            Customer customer = new Customer()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                StartDate = dateTimePicker1.Text,
                EndDate = dateTimePicker2.Text,
                RoomId = comboBox1.SelectedIndex,
                RoomDescription = comboBox2.SelectedText


            };

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
