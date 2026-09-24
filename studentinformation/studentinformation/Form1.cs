using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //creating variable to strore input data
            string studentname, department, allinformation;
            int studentid, semester;

            studentname = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);
            //processing data
            allinformation = studentname + " " + studentid + " " + department + " " + semester;
            //Display out put 
            lbloutput.Text = allinformation;

        }
   
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
