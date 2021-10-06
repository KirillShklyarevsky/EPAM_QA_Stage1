using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.MailRu;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class LogInMailRuTest
    {
        private IWebDriver _driver;
        private const string _loginPagePath = "https://account.mail.ru/login";
        private const string _username = "seleniumtetst1";
        private const string _password = "tFgmQrQ3m32hNWx";
        private const string _incorrectUsername = "qwdqjw";
        private const string _incorrectPassword = "jfewfjwo";
        private const string _errorEmptyUsernameMessage = "Поле «Имя аккаунта» должно быть заполнено";
        private const string _errorEmptyPasswordMessage = "Поле «Пароль» должно быть заполнено";
        private const string _errorIncorrectUsernameMessage = "Такой аккаунт не зарегистрирован";
        private const string _errorIncorrectPasswordMessage = "Неверный пароль, попробуйте ещё раз";

        [SetUp]
        public void Setup()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(_loginPagePath);
        }

        [Test]
        public void LogInWithValidUsernameAndPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);

            var actualPage = loginPage.LogIn(_username, _password);

            Assert.IsTrue(actualPage is InboxPage);
        }

        [Test]
        public void LogInWithEmptyUsername()
        {
            LoginPage loginPage = new LoginPage(_driver);

            loginPage.EnterUsername(string.Empty);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            Assert.AreEqual(_errorEmptyUsernameMessage, actual);
        }

        [Test]
        public void LogInWithEmptyPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);

            loginPage.EnterUsername(_username);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(string.Empty);
            loginPage.PressLogInButton();
            string actual = loginPage.GetErrorMessage();

            Assert.AreEqual(_errorEmptyPasswordMessage, actual);
        }

        [Test]
        public void LogInWithIncorrectUsername()
        {
            LoginPage loginPage = new LoginPage(_driver);

            loginPage.EnterUsername(_incorrectUsername);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            Assert.AreEqual(_errorIncorrectUsernameMessage, actual);
        }

        [Test]
        public void LogInWithIncorrectPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);

            loginPage.EnterUsername(_username);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(_incorrectPassword);
            loginPage.PressLogInButton();
            string actual = loginPage.GetErrorMessage();

            Assert.AreEqual(_errorIncorrectPasswordMessage, actual);
        }

        [TearDown]
        public void DriverQuit()
        {
            _driver.Quit();
        }
    }
}