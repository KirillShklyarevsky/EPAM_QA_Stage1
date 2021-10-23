using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Gmail
{
    public class LoginPage : BasePage
    {
        private const string _driverTitle = "Gmail";
        private readonly By _usernameLocator = By.XPath("//input[@type='email']");
        private readonly By _enterPasswordButtonLocator = By.XPath("//span[text()='Далее']");
        private readonly By _passwordLocator = By.XPath("//input[@name='password']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
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
            Wait.Until(ExpectedConditions.ElementIsVisible(_enterPasswordButtonLocator));
            Driver.FindElement(_enterPasswordButtonLocator).Click();

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