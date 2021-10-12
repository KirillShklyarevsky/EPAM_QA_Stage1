using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.MailRu
{
    public class SettingsPage : BasePage
    {
        private const string _driverTitle = "Личные данные";
        By userFirstnameLocator = By.XPath("//input[@id='firstname']");
        By userLastnameLocator = By.XPath("//input[@id='lastname']");
        By userNicknameLocator = By.XPath("//input[@id='nickname']");//value
        By saveButtonLocator = By.XPath("//span[text()='Сохранить']");

        public SettingsPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
        }

        public SettingsPage ChangeUserFirstname(string firstname)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userFirstnameLocator));
            Driver.FindElement(userFirstnameLocator).Clear();
            Driver.FindElement(userFirstnameLocator).SendKeys(firstname);

            return this;
        }

        public SettingsPage ChangeUserLastname(string lastname)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userLastnameLocator));
            Driver.FindElement(userLastnameLocator).Clear();
            Driver.FindElement(userLastnameLocator).SendKeys(lastname);

            return this;
        }

        public SettingsPage SaveNickname()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(saveButtonLocator));
            Driver.FindElement(saveButtonLocator).Click();

            return this;
        }

        public string ReadNickname()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userFirstnameLocator));
            Wait.Until(ExpectedConditions.ElementIsVisible(userLastnameLocator));
            string firstname = Driver.FindElement(userFirstnameLocator).GetAttribute("value");
            string lastname = Driver.FindElement(userLastnameLocator).GetAttribute("value");
            return firstname + " " + lastname;
        }

        public SettingsPage RenameUser(string firstname, string lastname)
        {
            ChangeUserFirstname(firstname);
            ChangeUserLastname(lastname);
            SaveNickname();

            return this;
        }
    }
}