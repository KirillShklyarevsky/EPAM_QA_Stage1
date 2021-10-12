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
        public void SendMessage()
        {
            SeleniumWebDriver.MailRu.LoginPage loginPage = new SeleniumWebDriver.MailRu.LoginPage(_driver);
            SeleniumWebDriver.MailRu.InboxPage inboxPage = loginPage.LogIn(_username, _password);
            inboxPage.SendMessage(_text, _receiverMail);
        }

        [Test]
        public void LogInToGmail()
        {
            _driver.Navigate().GoToUrl(_loginGmailPagePath);
            SeleniumWebDriver.Gmail.LoginPage loginPage = new SeleniumWebDriver.Gmail.LoginPage(_driver);
            SeleniumWebDriver.Gmail.InboxPage inboxPage = loginPage.LogIn(_receiverMail, _password);
            inboxPage.ReadLastMessage();
            inboxPage.ReplyMessage();
            inboxPage.EnterMessageText("Aaa Bbb");
            inboxPage.SendMessage();
        }

        [TearDown]
        public void DriverQuit()
        {
            _driver.Quit();
        }
    }
}
