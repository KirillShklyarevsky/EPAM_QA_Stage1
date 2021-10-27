namespace SeleniumWebDriver.Models
{
    public class Letter
    {
        public string LetterText { get; }

        public string Receiver { get; }

        public Letter(string letterText, string receiver)
        {
            LetterText = letterText;
            Receiver = receiver;
        }
    }
}