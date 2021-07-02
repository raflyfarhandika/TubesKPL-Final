using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TubesKPL_E_Pen
{
    public class LoginControl
    {
        public Boolean LoginController(Boolean kondisi)
        {
            if (kondisi)
            {
                MessageBox.Show("username dan password benar");
                new Isibiodata().Show();
                return true;
            }
            else
            {
                MessageBox.Show("username dan password salah");
                return false;
            }
        }
    }
}
