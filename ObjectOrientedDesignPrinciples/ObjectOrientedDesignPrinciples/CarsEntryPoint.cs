using System;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples
{
    class CarsEntryPoint
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            while (true)
            {
                Console.WriteLine("Enter your command: ");
                ICommand command = ConsoleCommandReader.GetCommand(Console.ReadLine().Split(' '));
                invoker.SetCommand(command);
                invoker.RunCommand();
            }
        }
    }
}