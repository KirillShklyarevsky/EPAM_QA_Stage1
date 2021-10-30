using NUnit.Framework;
using SeleniumWebDriver.MailRu;
using SeleniumWebDriver.Models;
using SeleniumWebDriver.Service;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class LogInMailRuTest : CommonConditions
    {
        private const string _errorEmptyUsernameMessage = "���� ���� �������� ������ ���� ���������";
        private const string _errorEmptyPasswordMessage = "���� �������� ������ ���� ���������";
        private const string _errorIncorrectUsernameMessage = "����� ������� �� ���������������";
        private const string _errorIncorrectPasswordMessage = "�������� ������, ���������� ��� ���";

        [Test]
        [Category("All")]
        [Category("Smoke")]
        public void LogInWithValidUsernameAndPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.MailRuUserWithCredentialsFromProperty();

            //act
            var actualPage = loginPage.LogIn(user);

            //assert
            Assert.IsTrue(actualPage is InboxPage);
        }

        [Test]
        [Category("All")]
        [Category("Smoke")]
        public void LogInWithEmptyUsername()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithEmptyUsername();

            //act
            loginPage.EnterUsername(user.Email);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorEmptyUsernameMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithEmptyPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithEmptyPassword();

            //act
            loginPage.EnterUsername(user.Email);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(user.Password);
            loginPage.PressLogInButtonWithExpectedError();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorEmptyPasswordMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithIvalidUsername()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithInvalidUsername();


            //act
            loginPage.EnterUsername(user.Email);
            loginPage.PressPasswordButton();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorIncorrectUsernameMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithInvalidPassword()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithInvalidPassword();

            //act
            loginPage.EnterUsername(user.Email);
            loginPage.PressPasswordButton();
            loginPage.EnterPassword(user.Password);
            loginPage.PressLogInButtonWithExpectedError();
            string actual = loginPage.GetErrorMessage();

            //assert
            Assert.AreEqual(_errorIncorrectPasswordMessage, actual);
        }
    }
}