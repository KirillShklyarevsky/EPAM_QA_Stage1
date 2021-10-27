using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.Service
{
    public static class UserCreator
    {
        private static readonly string userNameMailRu = "seleniumtetst1";
        private static readonly string userPasswordMailRu = "tFgmQrQ3m32hNWx";
        private static readonly string userNameGmail = "seleniumtest236@gmail.com";
        private static readonly string userPasswordGmail = "tFgmQrQ3m32hNWx";
        private static readonly string _incorrectUsername = "qwdqjw";
        private static readonly string _incorrectPassword = "jfewfjwo";

        public static User MailRuUserWithCredentialsFromProperty()
        {
            return new User(userNameMailRu, userPasswordMailRu);
        }

        public static User GmailUserWithCredentialsFromProperty()
        {
            return new User(userNameGmail, userPasswordGmail);
        }

        public static User UserWithEmptyUsername()
        {
            return new User(string.Empty, userPasswordMailRu);
        }

        public static User UserWithEmptyPassword()
        {
            return new User(userNameMailRu, string.Empty);
        }

        public static User UserWithInvalidUsername()
        {
            return new User(_incorrectUsername, userPasswordGmail);
        }

        public static User UserWithInvalidPassword()
        {
            return new User(userNameMailRu, _incorrectPassword);
        }
    }
}