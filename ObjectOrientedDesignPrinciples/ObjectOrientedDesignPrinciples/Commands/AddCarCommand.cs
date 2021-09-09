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

        public void Execute()
        {
            CarDealer.GetCarDealer().AddCar(_car);
            System.Console.WriteLine("Car added");
        }
    }
}
