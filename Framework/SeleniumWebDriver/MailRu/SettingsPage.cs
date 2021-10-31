using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NLog;

namespace SeleniumWebDriver.MailRu
{
    public class SettingsPage : BasePage
    {
        private readonly string _driverTitle = "Личные данные";
        private readonly By userFirstnameLocator = By.XPath("//input[@id='firstname']");
        private readonly By userLastnameLocator = By.XPath("//input[@id='lastname']");
        private readonly By saveButtonLocator = By.XPath("//span[text()='Сохранить']");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public SettingsPage(IWebDriver driver) : base(driver)
        {
            Wait.Until(ExpectedConditions.TitleContains(_driverTitle));
            _logger.Info("MailRu settings page opened");
        }

        public SettingsPage ChangeUserFirstname(string firstname)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userFirstnameLocator));
            Driver.FindElement(userFirstnameLocator).Clear();
            Driver.FindElement(userFirstnameLocator).SendKeys(firstname);
            _logger.Info("Field firstname changed");

            return this;
        }

        public SettingsPage ChangeUserLastname(string lastname)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userLastnameLocator));
            Driver.FindElement(userLastnameLocator).Clear();
            Driver.FindElement(userLastnameLocator).SendKeys(lastname);
            _logger.Info("Field lastname changed");

            return this;
        }

        public SettingsPage SaveNickname()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(saveButtonLocator));
            Driver.FindElement(saveButtonLocator).Click();
            _logger.Info("New settings saved");

            return this;
        }

        public string ReadNickname()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(userFirstnameLocator));
            Wait.Until(ExpectedConditions.ElementIsVisible(userLastnameLocator));
            string firstname = Driver.FindElement(userFirstnameLocator).GetAttribute("value");
            string lastname = Driver.FindElement(userLastnameLocator).GetAttribute("value");
            _logger.Info("Nickname readed");

            return (firstname + " " + lastname);
        }

        public SettingsPage RenameUser(string firstname, string lastname)
        {
            ChangeUserFirstname(firstname);
            ChangeUserLastname(lastname);
            SaveNickname();
            _logger.Info("User renamed");

            return this;
        }
    }
}