using System;
using System.Collections.Generic;
using ObjectOrientedDesignPrinciples.Interfaces;
using ObjectOrientedDesignPrinciples.Commands;

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
                ICommand command = ConsoleCommandReader.GetCommand( Console.ReadLine().Split(' '));
                invoker.SetCommand(command);
                invoker.RunCommand();
            }

            // Console.ReadLine();

            

            //invoker.SetCommand(command);
            //invoker.RunCommand();

            //ICommand command1 = new AveragePriceCommand();
            //invoker.SetCommand(command1);
            //invoker.RunCommand();

            //ICommand command = new AddCarCommand(new Car("Audi", "A8", 25, 10000));
            //CarDealer.GetCarDealer().AddCar(new Car("Audi", "A8", 25, 10000));
            //CarDealer.GetCarDealer().AddCar(new Car("BMW", "4", 20, 20000));
            //CarDealer.GetCarDealer().AddCar(new Car("BMW", "7", 20, 80000));
            //CarDealer.GetCarDealer().AddCar(new Car("Buick", "Encore", 15, 30000));
            //CarDealer.GetCarDealer().AddCar(new Car("Maserati", "Spyder", 10, 40000));
            //CarDealer.GetCarDealer().AddCar(new Car("Subaru", "Legacy", 5, 50000));

            //Console.WriteLine(CarDealer.GetCarDealer().GetAveragePriceType("BMW"));
        }
    }
}