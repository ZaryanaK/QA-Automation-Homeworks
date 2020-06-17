using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Draggable
{
    public partial class DraggablePage : BasePage
    {
        public IWebElement InteractionsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]")));

        public IWebElement DraggableButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[5]")));

        public IWebElement DragBox => Wait.Until(d => d.FindElement(By.Id("dragBox")));

        public IWebElement AxisRestrictedButton => Wait.Until(d => d.FindElement(By.Id("draggableExample-tab-axisRestriction")));

        public IWebElement DragBoxOnlyX => Wait.Until(d => d.FindElement(By.Id("restrictedX")));

        public IWebElement DragBoxOnlyY => Wait.Until(d => d.FindElement(By.Id("restrictedY")));


    }
}
