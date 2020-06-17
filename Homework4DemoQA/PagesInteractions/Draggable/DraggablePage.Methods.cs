using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToDraggableSimple()
        {
            InteractionsButton.Click();
            ScrollTo(DraggableButton).Click();
        }

        public void GoToDraggableAxisRestricted()
        {
            InteractionsButton.Click();
            ScrollTo(DraggableButton).Click();
            AxisRestrictedButton.Click();
        }
    }
}
