using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.Service
{
    public class UserCreator
    {
        private static readonly string userNameMailRu = "testdata.mailru.user.name";
        private static readonly string userPasswordMailRu = "testdata.mailru.user.password";
        private static readonly string userNameGmail = "testdata.gmail.user.name";
        private static readonly string userPasswordGmail = "testdata.gmail.user.password";
        private static readonly string _incorrectUsername = "qwdqjw";
        private static readonly string _incorrectPassword = "jfewfjwo";

        public static User MailRuUserWithCredentialsFromProperty()
        {
            return new User { Email = TestDataReader.GetTestData(userNameMailRu), Password = TestDataReader.GetTestData(userPasswordMailRu) };
        }

        public static User GmailUserWithCredentialsFromProperty()
        {
            return new User { Email = TestDataReader.GetTestData(userNameGmail), Password = TestDataReader.GetTestData(userPasswordGmail) };
        }

        public static User UserWithEmptyUsername()
        {
            return new User { Email = string.Empty, Password = TestDataReader.GetTestData(userPasswordMailRu) };
        }

        public static User UserWithEmptyPassword()
        {
            return new User { Email = TestDataReader.GetTestData(userNameMailRu), Password = string.Empty };
        }

        public static User UserWithInvalidUsername()
        {
            return new User { Email = _incorrectUsername, Password = TestDataReader.GetTestData(userPasswordGmail) };
        }

        public static User UserWithInvalidPassword()
        {
            return new User { Email = TestDataReader.GetTestData(userNameMailRu), Password = _incorrectPassword };
        }
    }
}