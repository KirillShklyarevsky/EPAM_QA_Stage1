using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Gmail
{
    public class LoginPage : BasePage
    {
        By usernameLocator = By.XPath("//input[@type='email']");
        By enterPasswordButtonLocator = By.XPath("//span[text()='Далее']");
        By passwordLocator = By.XPath("//input[@name='password']");
        private const string _driverTitle = "Gmail";

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public LoginPage EnterUsername(string username)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(usernameLocator));
            Driver.FindElement(usernameLocator).SendKeys(username);

            return this;
        }

        public LoginPage PressPasswordButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(enterPasswordButtonLocator));
            Driver.FindElement(enterPasswordButtonLocator).Click();

            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(passwordLocator));
            Driver.FindElement(passwordLocator).SendKeys(password);

            return this;
        }

        public InboxPage PressLogInButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(enterPasswordButtonLocator));
            Driver.FindElement(enterPasswordButtonLocator).Click();

            return new InboxPage(Driver);
        }

        public InboxPage LogIn(string username, string password)
        {
            EnterUsername(username);
            PressPasswordButton();
            EnterPassword(password);
            return PressLogInButton();
        }
    }
}
