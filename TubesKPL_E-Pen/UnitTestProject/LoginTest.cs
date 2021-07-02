using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TubesKPL_E_Pen;
using System.Windows;

namespace UnitTestProject
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Will_Return_True_if_Username_and_Password_was_Correct_and_Change_to_IsibiodataFor()
        {
            Boolean Data = true;
            Assert.IsTrue(new LoginControl().LoginController(Data));
        }

        [TestMethod]
        public void Should_Return_Error_Json_File()
        {

            Assert.ThrowsException<FileNotFoundException>(() => {
                string data = File.ReadAllText("D:/Kuliah/Semester 4/Konstruksi Perangkat Lunak/TubesKPL-Final/TubesKPL-Final/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers1.json");
            });
        }
    }
}
