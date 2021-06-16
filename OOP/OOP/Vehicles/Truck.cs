using System;

namespace OOP
{
    [Serializable]
    public class Truck : VehicleBase
    {
        private double _maximumLoad;

        public double MaximumLoad
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maximumLoad = value;
            }

            get
            {
                return _maximumLoad;
            }
        }

        public Truck() { }

        public Truck(double maximumLoad, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumLoad = maximumLoad;
        }

        public override string GetInfo()
        {
            string truckInfo = base.GetInfo();
            return (truckInfo + $"Maximun load: {MaximumLoad}");
        }
    }
}