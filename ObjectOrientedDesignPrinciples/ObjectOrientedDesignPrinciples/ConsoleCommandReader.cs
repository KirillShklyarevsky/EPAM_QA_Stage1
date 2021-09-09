using System;
using ObjectOrientedDesignPrinciples.Commands;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples
{
    public static class ConsoleCommandReader
    {
        public static ICommand GetCommand(string[] commands)
        {
            ICommand command;

            switch (commands[0])
            {
                case "AddCar":
                    command = new AddCarCommand(new Car(commands[1], commands[2], Convert.ToInt32(commands[3]), Convert.ToDouble(commands[4])));
                    break;
                case "CountTypes":
                    command = new CountTypseCommand();
                    break;
                case "CountAll":
                    command = new CountAllCommand();
                    break;
                case "AveragePrice":
                    command = new AveragePriceCommand();
                    break;
                case "AveragePriceType":
                    command = new AveragePriceTypeCommand(commands[1]);
                    break;
                case "Exit":
                    command = new ExitCommand();
                    break;
                default:
                    command = null;
                    break;
            }

            if (command == null)
            {
                Console.WriteLine("No such command");
            }

            return command;
        }
    }
}