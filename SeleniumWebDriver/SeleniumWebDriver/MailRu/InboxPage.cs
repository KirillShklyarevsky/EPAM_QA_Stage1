using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumWebDriver.MailRu
{
    public class InboxPage
    {
        private IWebDriver _driver;

        public InboxPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
