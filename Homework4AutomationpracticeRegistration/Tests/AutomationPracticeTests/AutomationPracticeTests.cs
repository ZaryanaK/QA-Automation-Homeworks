using Homework4AutomationpracticeRegistration.Factories;
using Homework4AutomationpracticeRegistration.Models;
using Homework4AutomationpracticeRegistration.Pages.AutomationPracticePage;
using NUnit.Framework;

namespace Homework4AutomationpracticeRegistration.Tests.AutomationPracticeTests
{
    public class AutomationPracticeTests : BaseTest
    {
        private AutomationPracticePage _automationPracticePage;
        private AutomationPracticeModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            _automationPracticePage = new AutomationPracticePage(Driver);

            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void TheSameEmailFromSubmitionFormToRegistrationForm()
        {
            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();

            //Assert
            _automationPracticePage.AssertSameEmailIsInTheRefistrationForm();
        }

        [Test]
        public void AtLeastOnePhoneNumberRequired()
        {
            //Arrange
            _user.MobilePhone = string.Empty;

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillForm(_user);

            //Assert
            _automationPracticePage.AssertAtLeastOnePhoneNumberRequired();
        }

        [Test]
        public void FirstNameRequired()
        {
            //Arrange

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillFormWithoutFirstNameInYPISection(_user);

            //Assert
            _automationPracticePage.AssertFirstNameRequired();
        }

        [Test]
        public void LastNameRequired()
        {
            //Arrange

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillFormWithoutLastNameInYPISection(_user);

            //Assert
            _automationPracticePage.AssertLastNameRequired();
        }

        [Test]
        public void EmailRequired()
        {
            //Arrange

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillFormWithoutEmail(_user);

            //Assert
            _automationPracticePage.AssertEmailRequired();
        }

        [Test]
        public void Address1Required()
        {
            //Arrange
            _user.Address = string.Empty;

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillForm(_user);

            //Assert
            _automationPracticePage.AssertAddress1Required();
        }

        [Test]
        public void InvalidPostalCode()
        {
            //Arrange
            _user.Zip = "123";

            //Act
            _automationPracticePage.CreateAnAccountWithValidEmail();
            _automationPracticePage.FillForm(_user);

            //Assert
            _automationPracticePage.AssertInvalidPostalCode();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
