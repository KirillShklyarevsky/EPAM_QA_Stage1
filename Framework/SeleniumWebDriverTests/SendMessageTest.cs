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
            //arrange
            SeleniumWebDriver.MailRu.LoginPage mailRuLoginPage = new SeleniumWebDriver.MailRu.LoginPage(_driver);
            User mailRuUser = UserCreator.MailRuUserWithCredentialsFromProperty();
            User gamilUser = UserCreator.GmailUserWithCredentialsFromProperty();
            Letter letter = LetterCreator.CreateLetter();


            //act
            SeleniumWebDriver.MailRu.InboxPage mailRuInboxPage = mailRuLoginPage.LogIn(mailRuUser);
            mailRuInboxPage.SendMessage(letter);
            SeleniumWebDriver.Gmail.LoginPage gmailLoginPage = new SeleniumWebDriver.Gmail.LoginPage(_driver);
            SeleniumWebDriver.Gmail.InboxPage gmailInboxPage = gmailLoginPage.LogIn(gamilUser);
            gmailInboxPage.ReadLastMessage();
            string actual = gmailInboxPage.GetMessageContent();
            gmailInboxPage.ReplyMessage().EnterMessageText("Aaa Bbb");
            gmailInboxPage.SendMessage();

            //assert
            Assert.AreEqual(letter.LetterText, actual);
        }
    }
}