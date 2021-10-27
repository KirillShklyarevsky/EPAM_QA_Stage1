using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public abstract class BasePage
    {
        private readonly int _webDriverWaitTime = 15;

        public WebDriverWait Wait { get; }

        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(_webDriverWaitTime));
        }
    }
}