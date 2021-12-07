
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace ParkingSeleniumTests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _iWebDriver;

        [TestInitialize]
        public void SetUp()
        {
            //Location of the web driver
             _iWebDriver = new ChromeDriver("C:\\WebDriver");
            //Telling the driver which url to go to
            _iWebDriver.Navigate().GoToUrl(@"http://localhost:8081/");
        }
        [TestMethod]
        public void TestParkingLotOccupied()
        {
            IWebElement iWebElement = _iWebDriver.FindElement(By.Id("1"));
            var colorBefore = iWebElement.GetAttribute("background");
            _iWebDriver.ExecuteJavaScript("arguments[0].setAttribute('class', 'slot occupied')", iWebElement);
        }
    }
}
