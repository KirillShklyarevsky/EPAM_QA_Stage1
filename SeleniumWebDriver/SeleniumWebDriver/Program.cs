using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumWebDriver.MailRu;

namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver;
            string _username = "seleniumtetst1@mail.ru";
            string _password = "tFgmQrQ3m32hNWx";
            string _loginPagePath = "https://mail.ru";

            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(_loginPagePath);

            LoginPage loginPage = new LoginPage(_driver);

            var actualPage = loginPage.LogIn(_username, _password);
        }
    }
}