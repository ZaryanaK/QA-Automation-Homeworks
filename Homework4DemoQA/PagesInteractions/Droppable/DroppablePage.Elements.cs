using OpenQA.Selenium;

namespace Homework4DemoQA.PagesInteractions.Droppable
{
    public partial class DroppablePage : BasePage
    {
        public IWebElement InteractionsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[5]")));

        public IWebElement DroppableButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[4]")));

        public IWebElement DragBox => Wait.Until(d => d.FindElement(By.Id("draggable")));

        public IWebElement DropBox => Wait.Until(d => d.FindElement(By.Id("droppable")));

        public IWebElement AcceptButton => Wait.Until(d => d.FindElement(By.Id("droppableExample-tab-accept")));

        public IWebElement AcceptableBox => Wait.Until(d => d.FindElement(By.Id("acceptable")));

        public IWebElement DropHereBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[2]")));

        public IWebElement NotAcceptableBox => Wait.Until(d => d.FindElement(By.Id("notAcceptable")));
    }
}
