using NUnit.Framework;
using SeleniumWebDriver.Models;
using SeleniumWebDriver.Service;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class SendMessageTest : BaseTest
    {
        [Test]
        [Category("All")]
        public void LogInToGmail()
        {
            SeleniumWebDriver.MailRu.LoginPage mailRuLoginPage = new SeleniumWebDriver.MailRu.LoginPage(_driver);
            User mailRuUser = UserCreator.MailRuUserWithCredentialsFromProperty();
            User gamilUser = UserCreator.GmailUserWithCredentialsFromProperty();
            Letter letter = LetterCreator.CreateLetter();

            mailRuLoginPage.LogIn(mailRuUser).SendMessage(letter);
            SeleniumWebDriver.Gmail.LoginPage gmailLoginPage = new SeleniumWebDriver.Gmail.LoginPage(_driver);
            SeleniumWebDriver.Gmail.InboxPage gmailInboxPage = gmailLoginPage.LogIn(gamilUser);
            string actual = gmailInboxPage.ReadLastMessage().GetMessageContent();
            gmailInboxPage.ReplyMessage().EnterMessageText("Aaa Bbb").SendMessage();

            Assert.AreEqual(letter.LetterText, actual);
        }
    }
}