using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.Service
{
    public class LetterCreator
    {
        public static Letter CreateLetter()
        {
            return new Letter("Hello World", UserCreator.GmailUserWithCredentialsFromProperty().Email);
        }
    }
}