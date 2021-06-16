using System;

namespace OOP
{
    [Serializable]
    public class Car : VehicleBase
    {
        private int _numberOfDoors;

        public int NumberOfDoors
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                _numberOfDoors = value;
            }

            get
            {
                return _numberOfDoors;
            }
        }

        public Car() { }

        public Car(int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"Number of doors: {NumberOfDoors}");
        }
    }
}