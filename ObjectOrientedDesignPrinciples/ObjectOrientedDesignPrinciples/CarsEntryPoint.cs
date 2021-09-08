﻿using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    class CarsEntryPoint
    {
        static void Main(string[] args)
        {
            CarDealer.GetCarDealer().AddCar(new Car("Audi", "A8", 25, 10000));
            CarDealer.GetCarDealer().AddCar(new Car("BMW", "4", 20, 20000));
            CarDealer.GetCarDealer().AddCar(new Car("BMW", "7", 20, 80000));
            CarDealer.GetCarDealer().AddCar(new Car("Buick", "Encore", 15, 30000));
            CarDealer.GetCarDealer().AddCar(new Car("Maserati", "Spyder", 10, 40000));
            CarDealer.GetCarDealer().AddCar(new Car("Subaru", "Legacy", 5, 50000));

            Console.WriteLine(CarDealer.GetCarDealer().GetAveragePriceType("BMW"));
        }
    }
}