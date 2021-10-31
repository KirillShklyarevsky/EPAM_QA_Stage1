using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Models;
using NLog;

namespace SeleniumWebDriver.MailRu
{
    public class LoginPage : BasePage
    {

        private const string _loginPagePath = "https://account.mail.ru/login";
        private readonly string _driverTitle = "Авторизация";
        private readonly By _usernameLocator = By.XPath("//input[@name='username']");
        private readonly By _enterPasswordButtonLocator = By.XPath("//button[@type='submit']");
        private readonly By _passwordLocator = By.XPath("//input[@name='password']");
        private readonly By _logInButtonLocator = By.XPath("//span[text()='Войти']");
        private readonly By _errorMessage = By.XPath("//div[contains(@data-test-id,'error')]/small");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public LoginPage(IWebDriver driver) : base(driver)
        {
            OpenPage();
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }
        
        public LoginPage OpenPage()
        {
            Driver.Navigate().GoToUrl(_loginPagePath);
            _logger.Info("MailRu login page open");

            return this;
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
            Wait.Until(ExpectedConditions.ElementIsVisible(_logInButtonLocator));
            Driver.FindElement(_logInButtonLocator).Click();
            _logger.Info("User logged in");

            return new InboxPage(Driver);
        }

        public LoginPage PressLogInButtonWithExpectedError()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_logInButtonLocator));
            Driver.FindElement(_logInButtonLocator).Click();
            _logger.Error("User not logged with incorrect credentials");

            return this;
        }

        public InboxPage LogIn(User user)
        {
            EnterUsername(user.Email);
            PressPasswordButton();
            EnterPassword(user.Password);

            _logger.Info("User logged in");

            return PressLogInButton();
        }

        public string GetErrorMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_errorMessage));

            return Driver.FindElement(_errorMessage).Text;
        }

    }
}