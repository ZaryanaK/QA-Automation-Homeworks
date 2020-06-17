using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4GoogleSearch.Pages
{
    public partial class GooglePage : BasePage
    {
        public void AssertRightTitleOfTheFistResultAfterSearch()
        {
           string actualTitle = FirstResultAfterSearch.Text;
           Assert.AreEqual("Selenium", actualTitle);
        }

        public void AssertRightUrlAfterClickOnFirstResult()
        {
            string currUrl = Driver.Url;
            Assert.AreEqual("https://www.selenium.dev/", currUrl);
        }
    }
}
