using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public abstract class BasePage
    {
        public WebDriverWait Wait { get; }

        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(int.Parse(TestContext.Parameters["waitTime"])));
        }
    }
}