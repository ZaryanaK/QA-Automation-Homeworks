using Homework4DemoQA.PagesInteractions.Droppable;
using NUnit.Framework;


namespace Homework4DemoQA.Tests.InteractionsTests
{
    public class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

            _droppablePage = new DroppablePage(Driver);
        }

        [Test]
        public void Droppable_Simple_CheckPositionByColour()
        {
            //Act
            _droppablePage.GoToDroppableSimple();

            var colorBefore = _droppablePage.DropBox.GetCssValue("color");

            Builder
                .DragAndDrop(_droppablePage.DragBox, _droppablePage.DropBox)
                .Perform();

            var colorAfter = _droppablePage.DropBox.GetCssValue("background-color");

            //Assert
            _droppablePage.AssertDifferentColorOfDropBoxAfterMove(colorBefore, colorAfter);
        }

        [Test]
        public void Droppable_Accept_CheckPositionAcceptableByColour()
        {
            //Act
            _droppablePage.GoToDroppableAcceptable();

            var colorBefore = _droppablePage.DropHereBox.GetCssValue("background-color");

            Builder
                .MoveToElement(_droppablePage.AcceptableBox)
                .ClickAndHold()
                .MoveByOffset(300, 50)
                .Perform();

            var colorAfter = _droppablePage.DropHereBox.GetCssValue("background-color");

            //Assert
            _droppablePage.AssertDifferentColorOfDropBoxAfterMove(colorBefore, colorAfter);
        }

        [Test]
        public void Droppable_Accept_CheckPositionNotAcceptableByColour()
        {
            //Act
            _droppablePage.GoToDroppableAcceptable();

            var colorBefore = _droppablePage.DropHereBox.GetCssValue("background-color");

            Builder
                .MoveToElement(_droppablePage.NotAcceptableBox)
                .ClickAndHold()
                .MoveByOffset(300, 20)
                .Perform();

            var colorAfter = _droppablePage.DropHereBox.GetCssValue("background-color");

            //Assert
            _droppablePage.AssertSameColorOfDropBoxAfterMove(colorBefore, colorAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
