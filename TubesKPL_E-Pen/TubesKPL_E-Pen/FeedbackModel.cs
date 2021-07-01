using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_E_Pen
{
    class FeedbackModel
    {
        public void confirmButtonFeedback(string input)
        {
            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = input;
            }
        }
    }
}
