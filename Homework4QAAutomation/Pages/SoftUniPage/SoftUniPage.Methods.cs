using OpenQA.Selenium;


namespace Homework4QAAutomation.Pages.SoftUniPage
{
    public partial class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver) : base(driver)
        {

        }

        public void GoToQAAutomationPage()
        {
            EducationsButton.Click();
            ActiveModulesButton.Click();
            QualityAssuranceButton.Click();
            QAAutomationBox.Click();
        }
    }
}
