using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace Homework4AutomationpracticeRegistration.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }
    }
}
