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
            LoginPage loginPage = new LoginPage(_driver);
            User user = UserCreator.MailRuUserWithCredentialsFromProperty();

            InboxPage inboxPage = loginPage.LogIn(user);
            string expected = inboxPage.ReadLastMessage().GetMessageContent();
            string[] newNickname = expected.Split(' ');
            SettingsPage settingsPage = inboxPage.OpenOptions()
                                                 .OpenSettings()
                                                 .RenameUser(newNickname[0], newNickname[1]);
            _driver.Navigate().Refresh();
            string actualNickname = settingsPage.ReadNickname();

            Assert.AreEqual(expected, actualNickname);
        }
    }
}
