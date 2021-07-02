using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TubesKPL_E_Pen;

namespace E_Pen_Unit_Testing
{
    [TestClass]
    public class FeedbackTest
    {
        [TestMethod]
        public void TextBoxInputTest()
        {
            // Test method untuk input ke TextField.

            var textBoxTest = new FeedbackModel();
            textBoxTest.confirmButtonFeedback("String input test");
        }

        [TestMethod]
        public void StarButtonClickTest()
        {
            // Test Method untuk Table-driven Star.

            var starButtonTest = new FeedbackModel();
            starButtonTest.getStarText(FeedbackModel.Star.STAR1);
            starButtonTest.getStarText(FeedbackModel.Star.STAR2);
            starButtonTest.getStarText(FeedbackModel.Star.STAR3);
            starButtonTest.getStarText(FeedbackModel.Star.STAR4);
            starButtonTest.getStarText(FeedbackModel.Star.STAR5);
        }
    }
}
