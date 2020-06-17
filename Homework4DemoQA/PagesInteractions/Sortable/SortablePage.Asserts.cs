using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Sortable
{
    public partial class SortablePage : BasePage
    {
        public void AssertRightTextBoxOneAfterSwitch(string textAfter)
        {
            Assert.AreEqual("Two", textAfter);
        }

        public void AssertRightTextBoxTwoAfterSwitch(string textAfter)
        {
            Assert.AreEqual("One", textAfter);
        }
    }
}
