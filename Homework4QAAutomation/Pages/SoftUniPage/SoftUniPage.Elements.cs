using OpenQA.Selenium;

namespace Homework4QAAutomation.Pages.SoftUniPage
{
    public partial class SoftUniPage : BasePage
    {
        public IWebElement EducationsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span"))); 

        public IWebElement ActiveModulesButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]")));

        public IWebElement QualityAssuranceButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[2]/div[1]/ul/li/h2/a")));

        public IWebElement QAAutomationBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div[2]/div[3]/div/a/div[2]/h4")));

        public IWebElement HeaderBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/header/h1")));
    }
}
