using Homework4DemoQA.PagesInteractions.Selectable;
using NUnit.Framework;

namespace Homework4DemoQA.Tests.InteractionsTests
{
    public class SelectableTests : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

            _selectablePage = new SelectablePage(Driver);
        }

        [Test]
        public void Selectable_List_CheckSelectionOnFirstBox()
        {
            //Act
            _selectablePage.GoToSelectableList();

            var colorBefore = _selectablePage.FirstBox.GetCssValue("background-color");

            Builder
              .MoveToElement(_selectablePage.FirstBox)
              .Click()
              .Perform();

            var colorAfter = _selectablePage.FirstBox.GetCssValue("background-color");

            //Assert
            _selectablePage.AssertDifferentColorAfterSelection(colorBefore, colorAfter);
        }

        [Test]
        public void Selectable_List_CheckMultipleSelectionBoxOneAndTwo()
        {
            //Act
            _selectablePage.GoToSelectableList();

            var firstBoxColorBefore = _selectablePage.FirstBox.GetCssValue("background-color");
            var secondBoxColorBefore = _selectablePage.SecondBox.GetCssValue("background-color");

            Builder
              .MoveToElement(_selectablePage.FirstBox)
              .Click()
              .MoveToElement(_selectablePage.SecondBox)
              .Click()
              .Perform();

            var firstBoxColorAfter = _selectablePage.FirstBox.GetCssValue("background-color");
            var secondBoxColorAfter = _selectablePage.SecondBox.GetCssValue("background-color");

            //Assert
            _selectablePage.AssertDifferentColorAfterSelection(firstBoxColorBefore, firstBoxColorAfter);
            _selectablePage.AssertDifferentColorAfterSelection(secondBoxColorBefore, secondBoxColorAfter);
        }

        [Test]
        public void Selectable_List_CheckDeselectionOnFirstBox()
        {
            //Act
            _selectablePage.GoToSelectableList();

            Builder
              .MoveToElement(_selectablePage.FirstBox)
              .DoubleClick()
              .Perform();

            var colorAfter = _selectablePage.FirstBox.GetCssValue("background-color");

            //Assert
            _selectablePage.AssertWhiteColorAfterDeselection(colorAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
