using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Sortable
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToSortableList()
        {
            InteractionsButton.Click();
            ScrollTo(SortableButton).Click();
        }
    }
}
