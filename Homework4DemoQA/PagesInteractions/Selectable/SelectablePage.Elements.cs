using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement InteractionsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]")));

        public IWebElement SelectableButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[2]")));

        public IWebElement FirstBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]")));

        public IWebElement SecondBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[2]")));
    }
}
