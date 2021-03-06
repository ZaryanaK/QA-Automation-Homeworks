﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework4DemoQA.PagesInteractions
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        
        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        //public void WaitForLoad(int timeoutSec = 15)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //    WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
        //    wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        //}
    }
}
