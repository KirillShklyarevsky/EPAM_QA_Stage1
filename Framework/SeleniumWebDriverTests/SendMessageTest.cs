using NUnit.Framework;
using SeleniumWebDriver.Models;
using SeleniumWebDriver.Service;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class SendMessageTest : CommonConditions
    {
        private const string _text = "Hello World";

        [Test]
        public void LogInToGmail()
        {
            //arrange
            SeleniumWebDriver.MailRu.LoginPage mailRuLoginPage = new SeleniumWebDriver.MailRu.LoginPage(_driver);
            User mailRuUser = UserCreator.MailRuUserWithCredentialsFromProperty();
            User gamilUser = UserCreator.GmailUserWithCredentialsFromProperty();


            //act
            SeleniumWebDriver.MailRu.InboxPage mailRuInboxPage = mailRuLoginPage.LogIn(mailRuUser);
            mailRuInboxPage.SendMessage(_text, gamilUser.Email);
            SeleniumWebDriver.Gmail.LoginPage gmailLoginPage = new SeleniumWebDriver.Gmail.LoginPage(_driver);
            SeleniumWebDriver.Gmail.InboxPage gmailInboxPage = gmailLoginPage.LogIn(gamilUser);
            gmailInboxPage.ReadLastMessage();
            string actual = gmailInboxPage.GetMessageContent();
            gmailInboxPage.ReplyMessage();
            gmailInboxPage.EnterMessageText("Aaa Bbb");
            gmailInboxPage.SendMessage();

            //assert
            Assert.AreEqual(_text, actual);
        }
    }
}