
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace ParkingSeleniumTests
{
    [TestClass]
    public class VueAppTests
    {
        private IWebDriver _iWebDriver;

        [TestInitialize]
        public void SetUp()
        {
            //Location of the web driver (leave empty if nuget package with driver is installed)
             _iWebDriver = new ChromeDriver();
            //Telling the driver which url to go to. Change the url and port according to you local environment (Vue dev server)
            _iWebDriver.Navigate().GoToUrl("http://localhost:8080/");
        }
        [TestMethod]
        public void TestParkingLotOccupied()
        {
            IWebElement iWebElement = _iWebDriver.FindElement(By.Id("1"));
            var colorBefore = iWebElement.GetCssValue("background");
            _iWebDriver.ExecuteJavaScript("arguments[0].setAttribute('class', 'slot occupied')", iWebElement);
            var colorAfter = iWebElement.GetCssValue("background");

            Assert.AreNotEqual(colorAfter, colorBefore);
        }
    }
}
