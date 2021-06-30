using Newtonsoft.Json;
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

namespace TubesKPL_E_Pen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                inputPass.PasswordChar = '\0';
            } else
            {
                inputPass.PasswordChar = '•';
            }
        }

        private void forgetPass_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butnLogin_Click(object sender, EventArgs e)
        {
            Boolean Kondisi = true;
            if (string.IsNullOrEmpty(inputUsername.Text) && string.IsNullOrEmpty(inputPass.Text))
            {
                MessageBox.Show("Harap Masukkan Username dan Password dengan benar!!!!!!!!! -_-");
            }
            else
            {
                string data = File.ReadAllText("D:/Kuliah/Semester 4/Konstruksi Perangkat Lunak/TubesKPL-Final/TubesKPL-Final/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers.json");

                List<modelUser> DataUser = JsonConvert.DeserializeObject<List<modelUser>>(data);

                foreach (var item in DataUser)
                {
                    if (item.username == inputUsername.Text && item.password == inputPass.Text)
                    {
                        Kondisi = false;
                        break;
                    }
                }

                if (Kondisi == false)
                {
                    MessageBox.Show("username dan password benar gan");
                    this.Hide();
                    new Isibiodata().Show();
                }
                else
                {
                    MessageBox.Show("username dan password salah cok!!!");
                }
            }
        }

        private void inputPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
