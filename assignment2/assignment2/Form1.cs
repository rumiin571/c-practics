using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {

            dayofweektextbox.Clear();
            monthtextbox.Clear();
            dayofmonthtextbox.Clear();
            txtyear.Clear();
            dateoutputlabel.Text = "";
        }

        private void yearpromptlabel_Click(object sender, EventArgs e)
        {

        }

        private void dayofmonthpromptlabel_Click(object sender, EventArgs e)
        {

        }

        private void dayofweekpromptlabel_Click(object sender, EventArgs e)
        {

        }

        private void monthpromptlabel_Click(object sender, EventArgs e)
        {

        }

        private void dateoutputlabel_Click(object sender, EventArgs e)
        {

        }

        private void showdate_Click(object sender, EventArgs e)
        {
            string Dayoftheweek, month,day, year, fulldate;
            Dayoftheweek = dayofweektextbox.Text;
            month = monthtextbox.Text;
            day = dayofmonthtextbox.Text;
            year = txtyear.Text;

            fulldate = Dayoftheweek + "," + month + "," + day + "," + year;

            dateoutputlabel.Text = fulldate;
        }

        private void dayofmonthtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayofweektextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
