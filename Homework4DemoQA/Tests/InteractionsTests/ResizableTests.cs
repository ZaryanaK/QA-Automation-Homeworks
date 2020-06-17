using Homework4DemoQA.PagesInteractions.Resizable;
using NUnit.Framework;

namespace Homework4DemoQA.Tests.InteractionsTests
{
    public class ResizableTests : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");

            _resizablePage = new ResizablePage(Driver);
        }

        [Test]
        public void Resizable_CheckRestrictedBoxMaxSize()
        {
            //Act
            _resizablePage.GoToResizable();

            Builder
               .MoveToElement(_resizablePage.ResizableRestrictedBoxHandle)
               .ClickAndHold()
               .MoveByOffset(450, 250)
               .Perform();

            var handlePositionXAfter = _resizablePage.ResizableRestrictedBoxHandle.Location.X;
            var handlePositionYAfter = _resizablePage.ResizableRestrictedBoxHandle.Location.Y;

            //Assert
            _resizablePage.AssertRestrictedMaxSizeAfterMoveX(handlePositionXAfter);
            _resizablePage.AssertRestrictedMaxSizeAfterMoveY(handlePositionYAfter);
        }

        [Test]
        public void Resizable_CheckNotRestrictedBoxMinSize()
        {
            //Act
            _resizablePage.GoToResizable();

            Builder
              .MoveToElement(_resizablePage.ResizableNotRestrictedBoxHandle)
              .ClickAndHold()
              .MoveByOffset(-250, -250)
              .Perform();

            var handlePositionXAfter = _resizablePage.ResizableNotRestrictedBoxHandle.Location.X;
            var handlePositionYAfter = _resizablePage.ResizableNotRestrictedBoxHandle.Location.Y;

            //Assert
            _resizablePage.AssertNotRestrictedMinSizeAfterMoveX(handlePositionXAfter);
            _resizablePage.AssertNotRestrictedMinSizeAfterMoveY(handlePositionYAfter);
        }

        [TearDown]
        public void TearDown()
        {
           Driver.Quit();
        }
    }
}
