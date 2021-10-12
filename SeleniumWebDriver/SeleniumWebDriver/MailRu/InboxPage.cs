using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.MailRu
{
    public class InboxPage : BasePage
    {
        By _composeMessageButtonLocator = By.XPath("//a[@title='Написать письмо']");
        By receiverMailInputLocator = By.XPath("//input[@tabindex='100']");
        By textBoxLocator = By.XPath("//div[@role='textbox']");
        By sendMessageLocator = By.XPath("//span[@title='Отправить']");
        private readonly By lastMessageLocator = By.XPath("//div[@class='dataset__items']/a[contains(@class,'letter-bottom')][1]");
        By messageTextLocator = By.XPath("//div[@dir='ltr']");
        By optionsButtonLocator = By.XPath("//div[@class='ph-auth svelte-1xjymf4']");
        By settingsButtonLocator = By.XPath("//div[text()='Личные данные']");
        

        private const string _driverTitle = "Входящие";

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
            Wait.Until(ExpectedConditions.ElementIsVisible(receiverMailInputLocator));
            Driver.FindElement(receiverMailInputLocator).SendKeys(receiverMail);

            return this;
        }

        public InboxPage EnterText(string text)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(textBoxLocator));
            Driver.FindElement(textBoxLocator).SendKeys(text);

            return this;
        }
        public InboxPage PressSendMessageButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(sendMessageLocator));
            Driver.FindElement(sendMessageLocator).Click();

            return this;
        }

        public InboxPage SendMessage(string text, string receiverMail)
        {
            ComposeMessage();
            EnterReceiverMail(receiverMail);
            EnterText(text);
            PressSendMessageButton();

            return this;
        }

        public InboxPage ReadLastMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(lastMessageLocator));
            Driver.FindElement(lastMessageLocator).Click();

            return this;
        }

        public string GetMessageContent()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(messageTextLocator));
            return Driver.FindElement(messageTextLocator).Text;
        }

        public InboxPage OpenOptions()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(optionsButtonLocator));
            Driver.FindElement(optionsButtonLocator).Click();

            return this;
        }

        public SettingsPage OpenSettings()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(settingsButtonLocator));
            Driver.FindElement(settingsButtonLocator).Click();

            return new SettingsPage(Driver);
        }
    }
}