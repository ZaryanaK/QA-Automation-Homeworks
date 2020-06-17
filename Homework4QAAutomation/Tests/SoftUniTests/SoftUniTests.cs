using Homework4QAAutomation.Pages.SoftUniPage;
using NUnit.Framework;

namespace Homework4QAAutomation.Tests.SoftUniTests
{
    [TestFixture]
    public class SoftUniTests : BaseTest
    {
        private SoftUniPage _softUniPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://softuni.bg/");
            
            _softUniPage = new SoftUniPage(Driver);
        }

        [Test]
        public void RightTitleOfTheHeader()
        {
            _softUniPage.GoToQAAutomationPage();

            _softUniPage.AssertRightTitleOfTheHeader();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
