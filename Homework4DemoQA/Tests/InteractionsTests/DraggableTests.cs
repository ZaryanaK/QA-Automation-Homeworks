using Homework4DemoQA.PagesInteractions.Draggable;
using NUnit.Framework;

namespace Homework4DemoQA.Tests.InteractionsTests
{
    public class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

            _draggablePage = new DraggablePage(Driver);
        }

        [Test]
        public void Draggable_Simple_CheckPosition()
        {
            //Act
            _draggablePage.GoToDraggableSimple();

            var dragPositionXBefore = _draggablePage.DragBox.Location.X;
            var dragPositionYBefore = _draggablePage.DragBox.Location.Y;

            Builder
                .MoveToElement(_draggablePage.DragBox)
                .ClickAndHold()
                .MoveByOffset(100, 100)
                .Perform();

            var dragPositionXAfter = _draggablePage.DragBox.Location.X;
            var dragPositionYAfter = _draggablePage.DragBox.Location.Y;

            //Assert
            _draggablePage.AssertNewPositionAfterMove(dragPositionXBefore, dragPositionXAfter);
            _draggablePage.AssertNewPositionAfterMove(dragPositionYBefore, dragPositionYAfter);
        }

        [Test]
        public void Draggable_AxisRestricted_CheckPositionOnlyX()
        {
            //Act
            _draggablePage.GoToDraggableAxisRestricted();

            var dragPositionXBefore = _draggablePage.DragBoxOnlyX.Location.X;
            var dragPositionYBefore = _draggablePage.DragBoxOnlyX.Location.Y;

            Builder
                .MoveToElement(_draggablePage.DragBoxOnlyX)
                .ClickAndHold()
                .MoveByOffset(100, 50)
                .Perform();

            var dragPositionXAfter = _draggablePage.DragBoxOnlyX.Location.X;
            var dragPositionYAfter = _draggablePage.DragBoxOnlyX.Location.Y;

            //Assert
            _draggablePage.AssertNewPositionAfterMove(dragPositionXBefore, dragPositionXAfter);
            _draggablePage.AssertSamePositionAfterMove(dragPositionYBefore, dragPositionYAfter);
        }

        [Test]
        public void Draggable_AxisRestricted_CheckPositionOnlyY()
        {
            //Act
            _draggablePage.GoToDraggableAxisRestricted();

            var dragPositionXBefore = _draggablePage.DragBoxOnlyY.Location.X;
            var dragPositionYBefore = _draggablePage.DragBoxOnlyY.Location.Y;

            Builder
                .MoveToElement(_draggablePage.DragBoxOnlyY)
                .ClickAndHold()
                .MoveByOffset(50, 100)
                .Perform();

            var dragPositionXAfter = _draggablePage.DragBoxOnlyY.Location.X;
            var dragPositionYAfter = _draggablePage.DragBoxOnlyY.Location.Y;

            //Assert
            _draggablePage.AssertSamePositionAfterMove(dragPositionXBefore, dragPositionXAfter);
            _draggablePage.AssertNewPositionAfterMove(dragPositionYBefore, dragPositionYAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
