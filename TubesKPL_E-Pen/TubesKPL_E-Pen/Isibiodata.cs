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
        public enum Month { Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September, Oktober, November, Desember }

        public static int GetDays(Month bulan)
        {
            int[] dayPerMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return dayPerMonth[(int)bulan];
        }

        public Isibiodata()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Feedback().Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tanggal.Items.Clear();

            Tanggal.Text = "";

            string bulannya = Bulan.GetItemText(Bulan.SelectedItem);

            int j = GetDays((Month)Enum.Parse(typeof(Month), bulannya));

            for (int i = 1; i <= j; i++)
            {
                Tanggal.Items.Add(i);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



