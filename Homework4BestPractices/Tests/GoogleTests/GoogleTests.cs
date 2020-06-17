using Homework4GoogleSearch.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
