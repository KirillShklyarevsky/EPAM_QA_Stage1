using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.MailRu;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class LogInMailRuTest : CommonConditions
    {
        private const string _username = "seleniumtetst1";
        private const string _password = "tFgmQrQ3m32hNWx";
        private const string _incorrectUsername = "qwdqjw";
        private const string _incorrectPassword = "jfewfjwo";
        private const string _errorEmptyUsernameMessage = "���� ���� �������� ������ ���� ���������";
        private const string _errorEmptyPasswordMessage = "���� �������� ������ ���� ���������";
        private const string _errorIncorrectUsernameMessage = "����� ������� �� ���������������";
        private const string _errorIncorrectPasswordMessage = "�������� ������, ���������� ��� ���";

        [Test]
        public void LogInWithValidUsernameAndPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            
            //act
            var actualPage = loginPage.LogIn(_username, _password);

            //assert
            Assert.IsTrue(actualPage is InboxPage);
        }

        [Test]
        public void LogInWithEmptyUsername()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);

            //act
            loginPage.EnterUsername(string.Empty);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorEmptyUsernameMessage, actual);
        }

        [Test]
        public void LogInWithEmptyPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);

            //act
            loginPage.EnterUsername(_username);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(string.Empty);
            loginPage.PressLogInButtonWithExpectedError();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorEmptyPasswordMessage, actual);
        }

        [Test]
        public void LogInWithIncorrectUsername()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);

            //act
            loginPage.EnterUsername(_incorrectUsername);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorIncorrectUsernameMessage, actual);
        }

        [Test]
        public void LogInWithIncorrectPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);

            //act
            loginPage.EnterUsername(_username);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(_incorrectPassword);
            loginPage.PressLogInButtonWithExpectedError();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorIncorrectPasswordMessage, actual);
        }

        [TearDown]
        public void DriverQuit()
        {
            _driver.Quit();
        }
    }
}