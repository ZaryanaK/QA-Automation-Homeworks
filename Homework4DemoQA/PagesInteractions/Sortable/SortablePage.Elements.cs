using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Sortable
{
    public partial class SortablePage : BasePage
    {
        public IWebElement InteractionsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]")));

        public IWebElement SortableButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[1]")));

        public IWebElement BoxOneBefore => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")));

        public IWebElement BoxTwoBefore => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[2]")));

        public IWebElement BoxOneAfterSwitchWithBoxTwo => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[2]")));

        public IWebElement BoxTwoAfterSwitchWithBoxOne => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")));
    }
}
