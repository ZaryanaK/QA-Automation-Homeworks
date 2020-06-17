using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToDroppableSimple()
        {
            InteractionsButton.Click();
            ScrollTo(DroppableButton).Click();
        }

        public void GoToDroppableAcceptable()
        {
            InteractionsButton.Click();
            ScrollTo(DroppableButton).Click();
            AcceptButton.Click();
        }
    }
}
