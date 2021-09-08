using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class AddCarCommand : ICommand
    {
        private Car _car;

        public AddCarCommand(Car car)
        {
            _car = car;
        }

        public void Execute(CarDealer carDealer)
        {
            carDealer.AddCar(_car);
        }
    }
}
