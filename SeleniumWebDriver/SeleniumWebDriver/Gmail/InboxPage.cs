using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.Gmail
{
    public class InboxPage : BasePage
    {
        private readonly string _driverTitle = "Входящие";
        private readonly By lastMessageLocator = By.XPath("//div[@role='tabpanel']//table/tbody/tr[1]/td[@role='gridcell']");
        private readonly By sendersMailLocator = By.XPath("//span[@class='go']");
        private readonly By messageContentLocator = By.XPath("//div[@class='a3s aiL ']/div[2]/div[1]");
        private readonly By replyButtonLocator = By.XPath("//span[@role='link'][text()='Ответить']");
        private readonly By textBoxLocator = By.XPath("//div[@aria-label='Текст письма']");
        private readonly By sendReplyButton = By.XPath("//div[text()='Отправить']");

        public InboxPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public InboxPage ReadLastMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(lastMessageLocator));
            Driver.FindElement(lastMessageLocator).Click();

            return this;
        }

        public string GetSendersMail()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(sendersMailLocator));
            return Driver.FindElement(sendersMailLocator).Text;
        }

        public string GetMessageContent()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(messageContentLocator));
            return Driver.FindElement(messageContentLocator).Text;
        }

        public InboxPage ReplyMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(replyButtonLocator));
            Driver.FindElement(replyButtonLocator).Click();

            return this;
        }

        public InboxPage EnterMessageText(string text)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(textBoxLocator));
            Driver.FindElement(textBoxLocator).SendKeys(text);

            return this;
        }

        public InboxPage SendMessage()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(sendReplyButton));
            Driver.FindElement(sendReplyButton).Click();

            return this;
        }
    }
}