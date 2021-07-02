using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_E_Pen
{
    public class FeedbackModel
    {
        public FeedbackModel()
        {

        }

        public enum Star { STAR1, STAR2, STAR3, STAR4, STAR5 };

        public string getStarText(Star input)
        {
            // Table-driven untuk tulisan "Star".

            string[] outputStar =
            {
                "1 Star",
                "2 Star",
                "3 Star",
                "4 Star",
                "5 Star"
            };

            return outputStar[(int)input];
        }

        public void confirmButtonFeedback(string input)
        {
            // Mengisi array dengan text dari TextField.

            string[] terms = new string[400];
            for (int runs = 0; runs < 400; runs++)
            {
                terms[runs] = input;
            }
        }
    }
}
