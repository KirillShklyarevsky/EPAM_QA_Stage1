using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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

        public InboxPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public InboxPage ReadLastMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_lastMessageLocator));
            Driver.FindElement(_lastMessageLocator).Click();

            return this;
        }

        public string GetSendersMail()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_sendersMailLocator));

            return Driver.FindElement(_sendersMailLocator).Text;
        }

        public string GetMessageContent()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_messageContentLocator));

            return Driver.FindElement(_messageContentLocator).Text;
        }

        public InboxPage ReplyMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_replyButtonLocator));
            Driver.FindElement(_replyButtonLocator).Click();

            return this;
        }

        public InboxPage EnterMessageText(string text)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_textBoxLocator));
            Driver.FindElement(_textBoxLocator).SendKeys(text);

            return this;
        }

        public InboxPage SendMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_sendReplyButton));
            Driver.FindElement(_sendReplyButton).Click();

            return this;
        }
    }
}