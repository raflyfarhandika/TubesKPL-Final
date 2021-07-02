using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TubesKPL_E_Pen;

namespace UnitTestProject
{
    [TestClass]
    public class SignUpTest
    {
        //-------- BAGIAN PARSING --------
        //Test File Json
        [TestMethod]
        public void Json_File_Test()
        {
            //Membaca file Json
            string data = File.ReadAllText("D:/Coddingan/C#/Tugas Praktikum Kelompok/TUBESSSSSSSS/TubesKPL-Final/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers.Json");
            List<modelUser> DataUser = JsonConvert.DeserializeObject<List<modelUser>>(data);

            //Cek ada atau tidak file Jsonnya
            Assert.IsNotNull(DataUser);
        }

        //-------- BAGIAN DEFENSIVE --------
        //Test untuk bagian if else
        [TestMethod]
        public void RegisterForm_True_or_False()
        {
            var testIfElse = new modelUser();

            testIfElse.email = "kplepen@gmail.com";
            testIfElse.username = "kplepen";
            testIfElse.password = "kplepen";
            testIfElse.confirmPass = "kplepen";

            //Jika username, email, password, dan confirm password kosong maka gagal
            if (testIfElse.username == "" && testIfElse.email == "" && testIfElse.password == "" && testIfElse.confirmPass == "")
            {
                //Ketika semua field kosong maka gagal
            }

            //Jika hanya password dan confirm password kosong maka gagal
            else if (testIfElse.password == "" && testIfElse.confirmPass == "")
            {
                //Ketika field Password dan Confirm Pasword kosong maka gagal
            }

            //Jika Pasword dan Confirm Password sudah diisi maka berhasil
            else if (testIfElse.password == testIfElse.confirmPass)
            {
                //Ketika field Password dan Confirm Password sudha diisi maka berhasil
            }

            //Lain jika kondisi dimana Password dan Confirm Password memiliki perbedaan maka gagal
            else
            {
                //Ketika Password dan Confirm Password tidak sama maka gagal
            }
        }
    }
}
