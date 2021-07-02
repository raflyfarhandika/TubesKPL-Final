using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TubesKPL_E_Pen;

namespace E_Pen_Unit_Testing
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
            // Throw Exception File tidak ada di dalam direktori
            Assert.ThrowsException<FileNotFoundException>(() => {
                string data = File.ReadAllText("D:/Kuliah/Semester 4/Test/TubesKPL-Final-main/TubesKPL_E-Pen/TubesKPL_E-Pen/modelUsers1.json");
            });
        }
    }
}
