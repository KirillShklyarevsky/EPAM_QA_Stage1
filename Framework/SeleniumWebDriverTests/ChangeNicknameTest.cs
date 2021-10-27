using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.MailRu;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class ChangeNicknameTest : CommonConditions
    {
        private const string _username = "seleniumtetst1";
        private const string _password = "tFgmQrQ3m32hNWx";

        [Test]
        public void LogInToGmail()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);

            //act
            InboxPage inboxPage = loginPage.LogIn(_username, _password);
            inboxPage.ReadLastMessage();
            string expected = inboxPage.GetMessageContent();
            string[] newNickname = expected.Split(' ');
            inboxPage.OpenOptions();
            SettingsPage settingsPage = inboxPage.OpenSettings();
            settingsPage.RenameUser(newNickname[0], newNickname[1]);
            _driver.Navigate().Refresh();
            string actualNickname = settingsPage.ReadNickname();

            //assert
            Assert.AreEqual(expected, actualNickname);
        }

        [TearDown]
        public void DriverQuit()
        {
            _driver.Quit();
        }
    }
}
