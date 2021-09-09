﻿using System;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class AveragePriceTypeCommand : ICommand
    {
        private string _brand;

        public AveragePriceTypeCommand(string brand)
        {
            _brand = brand;
        }

        public void Execute()
        {
            Console.WriteLine($"Average price {_brand} : {CarDealer.GetCarDealer().GetAveragePrice()}");
        }
    }
}