using NUnit.Framework;

namespace Homework4AutomationpracticeRegistration.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public void AssertSameEmailIsInTheRefistrationForm()
        {
            Assert.AreEqual("selenium@abv.bg", EmailBar.GetAttribute("value"));
        }

        public void AssertAtLeastOnePhoneNumberRequired()
        {
            Assert.AreEqual("You must register at least one phone number.", ErrorBox.Text);
        }

        public void AssertFirstNameRequired()
        {
            Assert.AreEqual("firstname is required.", ErrorBox.Text);
        }

        public void AssertLastNameRequired()
        {
            Assert.AreEqual("lastname is required.", ErrorBox.Text);
        }

        public void AssertEmailRequired()
        {
            Assert.AreEqual("email is required.", ErrorBox.Text);
        }

        public void AssertAddress1Required()
        {
            Assert.AreEqual("address1 is required.", ErrorBox.Text);
        }

        public void AssertInvalidPostalCode()
        {
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", ErrorBox.Text);
        }
    }
}
