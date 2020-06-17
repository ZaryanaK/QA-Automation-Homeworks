using NUnit.Framework;


namespace Homework4QAAutomation.Pages.SoftUniPage
{
    public partial class SoftUniPage : BasePage
    {
        public void AssertRightTitleOfTheHeader()
        {
            string actualTitle = HeaderBox.Text;
            Assert.AreEqual("QA Automation - май 2020", actualTitle);
        }
    }
}
