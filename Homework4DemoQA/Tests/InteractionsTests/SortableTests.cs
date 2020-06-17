

using Homework4DemoQA.PagesInteractions.Sortable;
using NUnit.Framework;

namespace Homework4DemoQA.Tests.InteractionsTests
{
    public class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

            _sortablePage = new SortablePage(Driver);
        }

        [Test]
        public void Sortable_List_CheckChangeOfBoxesOneAndTwo()
        {
            //Act
            _sortablePage.GoToSortableList();

            Builder
              .DragAndDrop(_sortablePage.BoxOneBefore, _sortablePage.BoxTwoBefore)
              .Perform();

            var textBoxOneAfter = _sortablePage.BoxOneAfterSwitchWithBoxTwo.Text;
            var textBoxTwoAfter = _sortablePage.BoxTwoAfterSwitchWithBoxOne.Text;

            //Assert
            _sortablePage.AssertRightTextBoxOneAfterSwitch(textBoxOneAfter);
            _sortablePage.AssertRightTextBoxTwoAfterSwitch(textBoxTwoAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
