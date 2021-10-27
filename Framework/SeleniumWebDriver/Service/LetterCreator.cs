using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.Service
{
    public static class LetterCreator
    {
        public static Letter CreateLetter()
        {
            return new Letter("Hello World!", UserCreator.GmailUserWithCredentialsFromProperty().Email);
        }
    }
}