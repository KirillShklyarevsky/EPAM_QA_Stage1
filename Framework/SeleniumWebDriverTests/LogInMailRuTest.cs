using NUnit.Framework;
using SeleniumWebDriver.MailRu;
using SeleniumWebDriver.Models;
using SeleniumWebDriver.Service;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class LogInMailRuTest : BaseTest
    {
        private const string _errorEmptyUsernameMessage = "Поле «Имя аккаунта» должно быть заполнено";
        private const string _errorEmptyPasswordMessage = "Поле «Пароль» должно быть заполнено";
        private const string _errorIncorrectUsernameMessage = "Такой аккаунт не зарегистрирован";
        private const string _errorIncorrectPasswordMessage = "Неверный пароль, попробуйте ещё раз";

        [Test]
        [Category("All")]
        [Category("Smoke")]
        public void LogInWithValidUsernameAndPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.MailRuUserWithCredentialsFromProperty();

            var actualPage = loginPage.LogIn(user);

            Assert.IsTrue(actualPage is InboxPage);
        }

        [Test]
        [Category("All")]
        [Category("Smoke")]
        public void LogInWithEmptyUsername()
        {
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithEmptyUsername();

            string actual = loginPage.EnterUsername(user.Email)
                                     .PressPasswordButton()
                                     .GetErrorMessage();

            Assert.AreEqual(_errorEmptyUsernameMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithEmptyPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithEmptyPassword();

            string actual = loginPage.EnterUsername(user.Email)
                                     .PressPasswordButton()
                                     .EnterPassword(user.Password)
                                     .PressLogInButtonWithExpectedError()
                                     .GetErrorMessage();

            Assert.AreEqual(_errorEmptyPasswordMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithIvalidUsername()
        {
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithInvalidUsername();


            string actual = loginPage.EnterUsername(user.Email)
                                     .PressPasswordButton()
                                     .GetErrorMessage();

            Assert.AreEqual(_errorIncorrectUsernameMessage, actual);
        }

        [Test]
        [Category("All")]
        public void LogInWithInvalidPassword()
        {
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.UserWithInvalidPassword();

            string actual = loginPage.EnterUsername(user.Email)
                                     .PressPasswordButton()
                                     .EnterPassword(user.Password)
                                     .PressLogInButtonWithExpectedError()
                                     .GetErrorMessage();

            Assert.AreEqual(_errorIncorrectPasswordMessage, actual);
        }
    }
}