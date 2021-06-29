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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Memanggil class db_register
            var userRegister = new modelUser();
            userRegister.username = inputUsername.Text;
            userRegister.email = inputEmail.Text;
            userRegister.password = inputPass.Text;

            //Membaca File JSON
            string bacaData = File.ReadAllText("D:/Coddingan/C#/Tugas Praktikum Kelompok/TUBESSSSSSSS/TubesKPL-Final/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers.Json");

            List<modelUser> listJson = JsonConvert.DeserializeObject<List<modelUser>>(bacaData);
            listJson.Add(userRegister);
            var data = JsonConvert.SerializeObject(listJson, Formatting.Indented);
            //Menulis ke File JSON
            File.WriteAllText("D:/Coddingan/C#/Tugas Praktikum Kelompok/TUBESSSSSSSS/TubesKPL-Final/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers.Json", data);

            //Jika username, email, password, dan confirm password kosong maka gagal
            if (inputUsername.Text == "" && inputEmail.Text == "" && inputPass.Text == "" && inputConfirmPass.Text == "")
            {
                //Memperlihatkan pesan
                MessageBox.Show("Registration field are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Jika hanya password dan confirm password kosong maka gagal
            else if (inputPass.Text == "" && inputConfirmPass.Text == "")
            {
                //Memperlihatkan pesan
                MessageBox.Show("Password field are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Jika pasword dan confirm password sudah diisi maka berhasil
            else if (inputPass.Text == inputConfirmPass.Text)
            {
                //Memperlihatkan pesan
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Berpindah ke Halaman Login
                new Login().Show();
                this.Hide();
            }
            //Lain jika kondisi dimana password dan confirm password memiliki perbedaan maka gagal
            else
            {
                //Memperlihatkan pesan
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Untuk menghapus agar user bisa memasukan kembali datanya
                inputPass.Text = "";
                inputConfirmPass.Text = "";
                inputPass.Focus();

            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //Jika di centang maka password muncul
            if (chkShowPass.Checked)
            {
                inputPass.PasswordChar = '\0';
                inputConfirmPass.PasswordChar = '\0';
            }
            //Jika tidak di centang maka password hide
            else
            {
                inputPass.PasswordChar = '•';
                inputConfirmPass.PasswordChar = '•';
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Untuk Berpindah ke halaman Login
            new Login().Show();
            this.Hide();
        }
    }
}
