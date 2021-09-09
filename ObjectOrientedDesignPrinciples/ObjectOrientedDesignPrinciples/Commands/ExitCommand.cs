using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            System.Environment.Exit(0);
        }
    }
}