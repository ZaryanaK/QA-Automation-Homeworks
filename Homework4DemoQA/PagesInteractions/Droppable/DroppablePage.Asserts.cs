using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public void AssertDifferentColorOfDropBoxAfterMove(string colourBefore, string colourAfter)
        {
            Assert.AreNotEqual(colourBefore, colourAfter);
        }

        public void AssertSameColorOfDropBoxAfterMove(string colourBefore, string colourAfter)
        {
            Assert.AreEqual(colourBefore, colourAfter);
        }
    }
}
