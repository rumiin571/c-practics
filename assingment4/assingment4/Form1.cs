using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        // Handles textBox5 text changes
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        // Handles customer name text changes
        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {
        }

        // Calculates the electricity bill
        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get customer name
                string customer = txtcustumer.Text;

                // Get previous and current meter readings
                int previous = int.Parse(txtprevious.Text);
                int current = int.Parse(txtcurrent.Text);

                // Get price per unit
                double unitPrice = double.Parse(txtuntiprice.Text);

                // Calculate electricity usage
                int usage = current - previous;

                // Calculate electricity cost
                double electricityCost = usage * unitPrice;

                // Calculate 7% tax
                double tax = electricityCost * 0.07;

                // Calculate total bill with $5 service charge
                double total = electricityCost + tax + 5;
                // Display electricity usage
                txtusage.Text = usage.ToString();

                // Display tax
                txtTax.Text = "$" + tax.ToString("0.00");

                // Display total bill
                txtTotal.Text = "$" + total.ToString("0.00");
            }
            catch
            {
                // Show error message for invalid input
                MessageBox.Show("Please enter valid values.");
            }
        }
        // Handles the first Calculate button event
        private void btncalculate_Click_1(object sender, EventArgs e)
        {
        }

        // Handles the second Calculate button event
        private void btncalculate_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}
