using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NLog;

namespace SeleniumWebDriver.Gmail
{
    public class InboxPage : BasePage
    {
        private readonly string _driverTitle = "Входящие";
        private readonly By _lastMessageLocator = By.XPath("//div[@role='tabpanel']//table/tbody/tr[1]/td[@role='gridcell']");
        private readonly By _sendersMailLocator = By.XPath("//span[@class='go']");
        private readonly By _messageContentLocator = By.XPath("//div[@class='a3s aiL ']/div[2]/div[1]");
        private readonly By _replyButtonLocator = By.XPath("//span[@role='link'][text()='Ответить']");
        private readonly By _textBoxLocator = By.XPath("//div[@aria-label='Текст письма']");
        private readonly By _sendReplyButton = By.XPath("//div[text()='Отправить']");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public InboxPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
            _logger.Info("Gmail inbox page open");
        }

        public InboxPage ReadLastMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_lastMessageLocator));
            Driver.FindElement(_lastMessageLocator).Click();
            _logger.Info("Last message opened");

            return this;
        }

        public string GetSendersMail()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_sendersMailLocator));
            _logger.Info("Senders email readed");

            return Driver.FindElement(_sendersMailLocator).Text;
        }

        public string GetMessageContent()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_messageContentLocator));
            _logger.Info("Message content readed");

            return Driver.FindElement(_messageContentLocator).Text;
        }

        public InboxPage ReplyMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_replyButtonLocator));
            Driver.FindElement(_replyButtonLocator).Click();
            _logger.Info("Reply message window opened");

            return this;
        }

        public InboxPage EnterMessageText(string text)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_textBoxLocator));
            Driver.FindElement(_textBoxLocator).SendKeys(text);
            _logger.Info("Message text entered");

            return this;
        }

        public InboxPage SendMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_sendReplyButton));
            Driver.FindElement(_sendReplyButton).Click();
            _logger.Info("Message send");

            return this;
        }
    }
}