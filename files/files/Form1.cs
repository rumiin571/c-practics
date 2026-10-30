using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttwrite_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText("this file.doc");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to universti jamhuuriya");
            lines.WriteLine("class ca245");
            lines.WriteLine("Rumiin muse mohamud");
            MessageBox.Show("file successfully created and written!");
            //closing the lines
            lines.Close();
        }

            private void bwriteline_Click(object sender, EventArgs e)
        { 
            }


            private void bDeletfile_Click(object sender, EventArgs e)
            {
            }

            private void bReadALLline_Click(object sender, EventArgs e)
            {
         
        }

            private void bReadline_Click(object sender, EventArgs e)
            {
            }


            private void bDeletitem_Click(object sender, EventArgs e)
            {
               
            }

        private void bttread_Click(object sender, EventArgs e)
        {
            fist.Items.Clear();
            if (File.Exists("this file.doc"))
            {
                foreach (string line in File.ReadLines("this file.doc"))
                {
                    fist.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void bttreadall_Click(object sender, EventArgs e)
        {
            fist.Items.Clear();
            if (File.Exists("this file.doc"))
            {
                foreach (string line in File.ReadLines("this file.doc"))
                {
                    fist.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }

        private void bttfile_Click(object sender, EventArgs e)
        {
            //  Delete file button delete files
            if (File.Exists("this file.doc"))
            {
                File.Delete("this file.doc");
                fist.Items.Clear();
                MessageBox.Show("clear file.");
            }
            else
            {
                MessageBox.Show("file aan la arkeyna.");
            }
        }

        private void bttitems_Click(object sender, EventArgs e)
        {
            fist.Items.Clear();

        }
    }
    }

    

