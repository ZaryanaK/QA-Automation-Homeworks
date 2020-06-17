using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public void AssertNewPositionAfterMove(int positionBefore, int positionAfter)
        {
            Assert.AreNotEqual(positionBefore, positionAfter);
        }

        public void AssertSamePositionAfterMove(int positionBefore, int positionAfter)
        {
            Assert.AreEqual(positionBefore, positionAfter);
        }
    }
}
