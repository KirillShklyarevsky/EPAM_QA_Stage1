using System;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class CountTypseCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"Count types : {CarDealer.GetCarDealer().GetCountTypes()}");
        }
    }
}