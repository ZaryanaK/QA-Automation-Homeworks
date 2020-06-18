using OpenQA.Selenium;

namespace Homework4GoogleSearch.Pages
{
    public partial class GooglePage : BasePage
    {
        public IWebElement SearchTextField => Wait.Until(d => d.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input")));

        public IWebElement WhiteField => Wait.Until(d => d.FindElement(By.XPath("//*[@id='lga']")));

        public IWebElement GoogleSearchButton => Wait.Until(d => d.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]")));

        public IWebElement FirstResultAfterSearch => Wait.Until(d => d.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div[1]/a/h3")));
    }
}
