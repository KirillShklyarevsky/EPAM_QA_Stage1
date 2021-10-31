using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Models;
using NLog;

namespace SeleniumWebDriver.Gmail
{
    public class LoginPage : BasePage
    {
        private const string _loginPagePath = "https:/google.com/mail";
        private const string _driverTitle = "Gmail";
        private readonly By _usernameLocator = By.XPath("//input[@type='email']");
        private readonly By _enterPasswordButtonLocator = By.XPath("//span[text()='Далее']");
        private readonly By _passwordLocator = By.XPath("//input[@name='password']");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public LoginPage(IWebDriver driver) : base(driver)
        {
            OpenPage();
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public void OpenPage()
        {
            Driver.Navigate().GoToUrl(_loginPagePath);
            _logger.Info("Gmail login page open");
        }

        public LoginPage EnterUsername(string username)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_usernameLocator));
            Driver.FindElement(_usernameLocator).SendKeys(username);
            _logger.Info("Userename entered");

            return this;
        }

        public LoginPage PressPasswordButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_enterPasswordButtonLocator));
            Driver.FindElement(_enterPasswordButtonLocator).Click();
            _logger.Info("Password field opened");

            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_passwordLocator));
            Driver.FindElement(_passwordLocator).SendKeys(password);
            _logger.Info("Password entered");

            return this;
        }

        public InboxPage PressLogInButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_enterPasswordButtonLocator));
            Driver.FindElement(_enterPasswordButtonLocator).Click();
            _logger.Info("User logged in");

            return new InboxPage(Driver);
        }

        public InboxPage LogIn(User user)
        {
            EnterUsername(user.Email);
            PressPasswordButton();
            EnterPassword(user.Password);

            _logger.Info("User logged in");

            return PressLogInButton();
        }
    }
}