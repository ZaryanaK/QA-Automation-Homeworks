using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Resizable
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement InteractionsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]")));

        public IWebElement ResizableButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[3]")));

        public IWebElement ResizableRestrictedBoxHandle => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div/span")));

        public IWebElement ResizableNotRestrictedBoxHandle => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[2]/div/span")));


    }
}
