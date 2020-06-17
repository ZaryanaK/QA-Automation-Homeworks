using AutoFixture;
using OpenQA.Selenium;

namespace Homework4AutomationpracticeRegistration.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public IWebElement SignInButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")));

        public IWebElement EmailAddressBar => Wait.Until(d => d.FindElement(By.CssSelector("#email_create")));

        public IWebElement CreateAnAccountButton => Wait.Until(d => d.FindElement(By.CssSelector("#SubmitCreate")));

        public IWebElement EmailBar => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input")));

        public IWebElement FirstNameYPISection => Wait.Until(d => d.FindElement(By.Id("customer_firstname")));

        public IWebElement LastNameYPISection => Wait.Until(d => d.FindElement(By.Id("customer_lastname")));

        public IWebElement Password => Wait.Until(d => d.FindElement(By.Id("passwd")));

        public IWebElement FirstNameYASection => Wait.Until(d => d.FindElement(By.Id("firstname")));

        public IWebElement LastNameYASection => Wait.Until(d => d.FindElement(By.Id("lastname")));

        public IWebElement Address => Wait.Until(d => d.FindElement(By.Id("address1")));

        public IWebElement City => Wait.Until(d => d.FindElement(By.Id("city")));

        public IWebElement State => Wait.Until(d => d.FindElement(By.Id("id_state")));

        public IWebElement StateChoise => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select/option[3]")));

        public IWebElement Zip => Wait.Until(d => d.FindElement(By.Id("postcode")));

        public IWebElement MobilePhone => Wait.Until(d => d.FindElement(By.Id("phone_mobile")));

        public IWebElement AddressAlias => Wait.Until(d => d.FindElement(By.Id("alias")));

        public IWebElement RegisterButton => Wait.Until(d => d.FindElement(By.Id("submitAccount")));

        public IWebElement ErrorBox => Wait.Until(d => d.FindElement(By.XPath("//*[@id='center_column']/div/ol/li")));
    }
}
