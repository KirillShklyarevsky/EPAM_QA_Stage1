using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples
{
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void RunCommand()
        {
            if (_command == null)
            {
                return;
            }

            _command.Execute();
        }
    }
}