using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesKPL_E_Pen
{
    public partial class Isibiodata : Form
    {
        public Isibiodata()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = textBox2.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = textBox3.Text;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = textBox4.Text;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = textBox5.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
