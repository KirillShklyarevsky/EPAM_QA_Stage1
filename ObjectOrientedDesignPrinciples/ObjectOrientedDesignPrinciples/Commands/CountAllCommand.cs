using System;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class CountAllCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"Count of all cars : {CarDealer.GetCarDealer().GetCountAll()}");
        }
    }
}