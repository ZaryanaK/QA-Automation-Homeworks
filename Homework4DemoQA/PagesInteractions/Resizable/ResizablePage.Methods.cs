using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToResizable()
        {
            InteractionsButton.Click();
            ScrollTo(ResizableButton).Click();
        }
    }
}
