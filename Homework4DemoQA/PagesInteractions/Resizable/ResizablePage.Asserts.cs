using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public void AssertRestrictedMaxSizeAfterMoveX(int posAfter)
        {
            Assert.AreEqual(882, posAfter, "X position is max 882");
        }

        public void AssertRestrictedMaxSizeAfterMoveY(int posAfter)
        {
            Assert.AreEqual(516, posAfter, "Y position is max 516");
        }

        public void AssertNotRestrictedMinSizeAfterMoveX(int posAfter)
        {
            Assert.AreEqual(581, posAfter, "X position is min 581");
        }

        public void AssertNotRestrictedMinSizeAfterMoveY(int posAfter)
        {
            Assert.AreEqual(739, posAfter, "Y position is min 739");
        }

    }
}
