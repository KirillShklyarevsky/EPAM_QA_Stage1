using SeleniumWebDriver.Models;

namespace SeleniumWebDriver.Service
{
    public class LetterCreator
    {
        public static Letter CreateLetter()
        {
            return new Letter{ LetterText = "Hello World", Receiver = UserCreator.GmailUserWithCredentialsFromProperty().Email };
        }
    }
}