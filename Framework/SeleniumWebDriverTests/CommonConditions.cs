using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumWebDriver.Driver;
using SeleniumWebDriver.Utils;

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

        [TearDown]
        public void DriverQuit()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Error || TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                new Screenshotter().MakeScreenshot(_driver);
            }

            DriverSingleton.CloseDriver();
        }
    }
}