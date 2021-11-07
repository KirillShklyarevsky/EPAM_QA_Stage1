using NUnit.Framework;
using SeleniumWebDriver.MailRu;
using SeleniumWebDriver.Models;
using SeleniumWebDriver.Service;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class ChangeNicknameTest : BaseTest
    {
        [Test]
        [Category("All")]
        public void LogInToGmail()
        {
            //arrange
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.MailRuUserWithCredentialsFromProperty();

            //act
            InboxPage inboxPage = loginPage.LogIn(user);
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
    }
}
