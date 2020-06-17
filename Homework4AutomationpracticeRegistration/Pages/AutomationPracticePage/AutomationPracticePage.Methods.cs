using AutoFixture;
using Homework4AutomationpracticeRegistration.Models;
using OpenQA.Selenium;

namespace Homework4AutomationpracticeRegistration.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver) : base(driver)
        {

        }

        public void CreateAnAccountWithValidEmail()
        {
            SignInButton.Click();
            EmailAddressBar.SendKeys("selenium@abv.bg");
            CreateAnAccountButton.Click();
        }

        public void FillForm(AutomationPracticeModel user)
        {
            FirstNameYPISection.SendKeys(user.FirstNameYPISection);
            LastNameYPISection.SendKeys(user.LastNameYPISection);
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.Click();
            StateChoise.Click();
            Zip.SendKeys(user.Zip);
            MobilePhone.SendKeys(user.MobilePhone);
            AddressAlias.Clear();
            AddressAlias.SendKeys(user.AddressAlias);
            RegisterButton.Click();
        }

        public void FillFormWithoutFirstNameInYPISection(AutomationPracticeModel user)
        {
            LastNameYPISection.SendKeys(user.LastNameYPISection);
            Password.SendKeys(user.Password);
            FirstNameYASection.SendKeys("Gosho");
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.Click();
            StateChoise.Click();
            Zip.SendKeys(user.Zip);
            MobilePhone.SendKeys(user.MobilePhone);
            AddressAlias.Clear();
            AddressAlias.SendKeys(user.AddressAlias);
            RegisterButton.Click();
        }

        public void FillFormWithoutLastNameInYPISection(AutomationPracticeModel user)
        {
            FirstNameYPISection.SendKeys(user.FirstNameYPISection);
            Password.SendKeys(user.Password);
            LastNameYASection.SendKeys("Goshov");
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.Click();
            StateChoise.Click();
            Zip.SendKeys(user.Zip);
            MobilePhone.SendKeys(user.MobilePhone);
            AddressAlias.Clear();
            AddressAlias.SendKeys(user.AddressAlias);
            RegisterButton.Click();
        }

        public void FillFormWithoutEmail(AutomationPracticeModel user)
        {
            FirstNameYPISection.SendKeys(user.FirstNameYPISection);
            LastNameYPISection.SendKeys(user.LastNameYPISection);
            EmailBar.Clear();
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.Click();
            StateChoise.Click();
            Zip.SendKeys(user.Zip);
            MobilePhone.SendKeys(user.MobilePhone);
            AddressAlias.Clear();
            AddressAlias.SendKeys(user.AddressAlias);
            RegisterButton.Click();
        }


        //public void Type(IWebElement element, string text)
        //{
        //    element.Clear();
        //    element.SendKeys(text);
        //}
    }
}
