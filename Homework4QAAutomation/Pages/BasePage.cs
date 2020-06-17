﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework4QAAutomation.Pages
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
