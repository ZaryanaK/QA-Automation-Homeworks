using OpenQA.Selenium;
using NUnit.Framework;

namespace Homework4GoogleSearch.Pages
{
    public partial class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver) : base(driver)
        {

        }

        public void PerformGoogleSearch()
        {
            SearchTextField.SendKeys("selenium");
            WhiteField.Click();
            GoogleSearchButton.Click();
        }

        public void PerformGoogleSearchAndClickOnTheFirstResult()
        {
            SearchTextField.SendKeys("selenium");
            WhiteField.Click();
            GoogleSearchButton.Click();
            FirstResultAfterSearch.Click();
        }
    }
}
