using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.MailRu
{
    public class InboxPage : BasePage
    {
        By composeMessageButtonLocator = By.XPath("//a[@title='Написать письмо']");
        By receiverMailInputLocator = By.XPath("//input[@tabindex='100']");
        By textBoxLocator = By.XPath("//div[@role='textbox']");
        By sendMessageLocator = By.XPath("//span[@title='Отправить']");
        private const string _driverTitle = "Входящие";

        public InboxPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public InboxPage ComposeMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(composeMessageButtonLocator));
            Driver.FindElement(composeMessageButtonLocator).Click();

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
    }
}
