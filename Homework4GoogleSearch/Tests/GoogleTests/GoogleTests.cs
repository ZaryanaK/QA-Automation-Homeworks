using Homework4GoogleSearch.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework4GoogleSearch.Tests.GoogleTests
{
    [TestFixture]
    public class GoogleTests : BaseTest
    {
        private GooglePage _googlePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.google.com/");

            _googlePage = new GooglePage(Driver);
        }

        [Test]
        public void RightTitleOfTheFirstGoogleSearchResult()
        {
            _googlePage.PerformGoogleSearch();

            _googlePage.AssertRightTitleOfTheFistResultAfterSearch();
        }

        [Test]
        public void RightUrlOfTheFirstGoogleSearchResult()
        {
            _googlePage.PerformGoogleSearchAndClickOnTheFirstResult();

            _googlePage.AssertRightUrlAfterClickOnFirstResult();
        }

        [Test]
        public void ScreenshotTest()
        {
            _googlePage.PerformGoogleSearch();

            _googlePage.Assert_ScreenshotWrongAssert();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
