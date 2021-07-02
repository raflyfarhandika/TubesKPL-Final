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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1Star_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void button2Star_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void button3Star_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void button4Star_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Yellow;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void button5Star_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Yellow;
            pictureBox5.BackColor = Color.Yellow;
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            FeedbackModel inputText = new FeedbackModel();

            inputText.confirmButtonFeedback(textBox1.Text);

            MessageBox.Show("Thank you for your feedback.", "Feedback Completed", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
