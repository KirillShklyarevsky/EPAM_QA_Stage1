using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.MailRu
{
    public class LoginPage : BasePage
    {
        By usernameLocator = By.XPath("//input[@name='username']");
        By enterPasswordButtonLocator = By.XPath("//button[@type='submit']");
        By passwordLocator = By.XPath("//input[@name='password']");
        By logInButtonLocator = By.XPath("//span[text()='Войти']");
        By errorMessage = By.XPath("//div[contains(@data-test-id,'error')]/small");
        private string _driverTitle = "Авторизация";

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
            Wait.Until(ExpectedConditions.ElementIsVisible(logInButtonLocator));
            Driver.FindElement(logInButtonLocator).Click();

            return new InboxPage(Driver);
        }

        public InboxPage LogIn(string username, string password)
        {
            EnterUsername(username);
            PressPasswordButton();
            EnterPassword(password);
            return PressLogInButton();
        }

        public string GetErrorMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(errorMessage));

            return Driver.FindElement(errorMessage).Text;
        }

    }
}