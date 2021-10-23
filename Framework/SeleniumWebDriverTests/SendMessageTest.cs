using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.MailRu;
using SeleniumWebDriver.Gmail;

namespace SeleniumWebDriverTests
{
    [TestFixture]
    public class SendMessageTest
    {
        private IWebDriver _driver;
        private const string _loginMailRuPagePath = "https://account.mail.ru/login";
        private const string _loginGmailPagePath = "https:/google.com/mail";
        private const string _username = "seleniumtetst1";
        private const string _password = "tFgmQrQ3m32hNWx";
        private const string _receiverMail = "seleniumtest236@gmail.com";
        private const string _text = "Hello World";

        [SetUp]
        public void Setup()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(_loginMailRuPagePath);
        }

        [Test]
        public void LogInToGmail()
        {
            //arrange
            SeleniumWebDriver.MailRu.LoginPage mailRuLoginPage = new SeleniumWebDriver.MailRu.LoginPage(_driver);

            //act
            SeleniumWebDriver.MailRu.InboxPage mailRuInboxPage = mailRuLoginPage.LogIn(_username, _password);
            mailRuInboxPage.SendMessage(_text, _receiverMail);
            _driver.Navigate().GoToUrl(_loginGmailPagePath);
            SeleniumWebDriver.Gmail.LoginPage gmailLoginPage = new SeleniumWebDriver.Gmail.LoginPage(_driver);
            SeleniumWebDriver.Gmail.InboxPage gmailInboxPage = gmailLoginPage.LogIn(_receiverMail, _password);
            gmailInboxPage.ReadLastMessage();
            string actual = gmailInboxPage.GetMessageContent();
            gmailInboxPage.ReplyMessage();
            gmailInboxPage.EnterMessageText("Aaa Bbb");
            gmailInboxPage.SendMessage();

            //assert
            Assert.AreEqual(_text, actual);
        }

        [TearDown]
        public void DriverQuit()
        {
            _driver.Quit();
        }
    }
}