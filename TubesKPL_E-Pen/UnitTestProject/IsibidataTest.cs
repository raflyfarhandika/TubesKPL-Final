using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TubesKPL_E_Pen;

namespace UnitTestProject
{
    [TestClass]
    public class IsibidataTest
    {
        // Membuat index untuk menggambarkan inputnya
        public enum Month { Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September, Oktober, November, Desember };
        // Membuat Array untuk menggambarkan outputnya
        public static int GetDays(Month bulan)
        {
            int[] dayPerMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Mengembalikan hasil array
            return dayPerMonth[(int)bulan];
        }


        [TestMethod()]
        public void comboBox2_SelectedIndexChangedTest()
        {
            // Membuat Variabel baru untuk tes method
            GetDays Test = new GetDays(31);
        }
    }

    internal class GetDays
    {
        private object januari;

        public GetDays(object januari)
        {
            this.januari = januari;
        }
    }
}
