using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public void AssertDifferentColorAfterSelection(string colourBefore, string colourAfter)
        {
            Assert.AreNotEqual(colourBefore, colourAfter);
        }

        public void AssertWhiteColorAfterDeselection(string colourAfter)
        {
            Assert.AreEqual("rgba(248, 249, 250, 1)", colourAfter);
        }
    }
}
