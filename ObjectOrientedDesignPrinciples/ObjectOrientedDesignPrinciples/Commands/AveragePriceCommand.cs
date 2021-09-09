using System;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class AveragePriceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"Average price : {CarDealer.GetCarDealer().GetAveragePrice()}");
        }
    }
}