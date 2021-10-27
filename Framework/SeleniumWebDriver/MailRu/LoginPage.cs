using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Models;

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

        public LoginPage(IWebDriver driver) : base(driver)
        {
            OpenPage();
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }
        
        public LoginPage OpenPage()
        {
            Driver.Navigate().GoToUrl(_loginPagePath);

            return this;
        }

        public LoginPage EnterUsername(string username)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_usernameLocator));
            Driver.FindElement(_usernameLocator).SendKeys(username);

            return this;
        }

        public LoginPage PressPasswordButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_enterPasswordButtonLocator));
            Driver.FindElement(_enterPasswordButtonLocator).Click();

            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_passwordLocator));
            Driver.FindElement(_passwordLocator).SendKeys(password);

            return this;
        }

        public InboxPage PressLogInButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_logInButtonLocator));
            Driver.FindElement(_logInButtonLocator).Click();

            return new InboxPage(Driver);
        }

        public LoginPage PressLogInButtonWithExpectedError()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_logInButtonLocator));
            Driver.FindElement(_logInButtonLocator).Click();

            return this;
        }

        public InboxPage LogIn(User user)
        {
            EnterUsername(user.Email);
            PressPasswordButton();
            EnterPassword(user.Password);

            return PressLogInButton();
        }

        public string GetErrorMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_errorMessage));

            return Driver.FindElement(_errorMessage).Text;
        }

    }
}