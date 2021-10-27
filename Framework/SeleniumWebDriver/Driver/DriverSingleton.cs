using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWebDriver.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver _driver;
        private static object _locker = new object();

        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            lock (_locker)
            {
                if (_driver == null)
                {
                    switch (TestContext.Parameters["browser"])
                    {
                        case "firefox":
                            _driver = new FirefoxDriver();
                            break;
                        default:
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            _driver = new ChromeDriver();
                            break;
                    }
                    _driver.Manage().Window.Maximize();
                }
                return _driver;
            }
        }

        public static void CloseDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}