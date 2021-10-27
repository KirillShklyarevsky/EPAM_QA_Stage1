using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver.Driver;

namespace SeleniumWebDriverTests
{
    public class CommonConditions
    {
        protected IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = DriverSingleton.GetDriver();
        }
    }
}