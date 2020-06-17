using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToSelectableList()
        {
            InteractionsButton.Click();
            ScrollTo(SelectableButton).Click();
        }
    }
}
