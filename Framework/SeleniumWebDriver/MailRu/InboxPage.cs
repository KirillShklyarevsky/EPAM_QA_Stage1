using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.MailRu
{
    public class InboxPage : BasePage
    {

        private readonly string _driverTitle = "Входящие";
        private readonly By _composeMessageButtonLocator = By.XPath("//span[text()='Написать письмо']");
        private readonly By _receiverMailInputLocator = By.XPath("//input[@tabindex='100']");
        private readonly By _textBoxLocator = By.XPath("//div[@role='textbox']");
        private readonly By _sendMessageLocator = By.XPath("//span[@title='Отправить']");
        private readonly By _lastMessageLocator = By.XPath("//div[@class='dataset__items']/a[contains(@class,'letter-bottom')][1]");
        private readonly By _messageTextLocator = By.XPath("//div[@dir='ltr']");
        private readonly By _optionsButtonLocator = By.XPath("//div[@class='ph-auth svelte-1xjymf4']");
        private readonly By _settingsButtonLocator = By.XPath("//div[text()='Личные данные']");

        public InboxPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public InboxPage ComposeMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_composeMessageButtonLocator));
            Driver.FindElement(_composeMessageButtonLocator).Click();

            return this;
        }

        public InboxPage EnterReceiverMail(string receiverMail)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_receiverMailInputLocator));
            Driver.FindElement(_receiverMailInputLocator).SendKeys(receiverMail);

            return this;
        }

        public InboxPage EnterText(string text)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_textBoxLocator));
            Driver.FindElement(_textBoxLocator).SendKeys(text);

            return this;
        }
        public InboxPage PressSendMessageButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_sendMessageLocator));
            Driver.FindElement(_sendMessageLocator).Click();

            return this;
        }

        public InboxPage SendMessage(Letter letter)
        {
            ComposeMessage();
            EnterReceiverMail(letter.Receiver);
            EnterText(letter.LetterText);
            PressSendMessageButton();

            return this;
        }

        public InboxPage ReadLastMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_lastMessageLocator));
            Driver.FindElement(_lastMessageLocator).Click();

            return this;
        }

        public string GetMessageContent()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_messageTextLocator));
            return Driver.FindElement(_messageTextLocator).Text;
        }

        public InboxPage OpenOptions()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_optionsButtonLocator));
            Driver.FindElement(_optionsButtonLocator).Click();

            return this;
        }

        public SettingsPage OpenSettings()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(_settingsButtonLocator));
            Driver.FindElement(_settingsButtonLocator).Click();

            return new SettingsPage(Driver);
        }
    }
}