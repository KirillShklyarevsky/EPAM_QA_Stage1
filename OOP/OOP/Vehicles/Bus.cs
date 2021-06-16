using System;

namespace OOP
{
    [Serializable]
    public class Bus : VehicleBase
    {
        private int _seatsNumber;

        public int SeatsNumber
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                _seatsNumber = value;
            }

            get
            {
                return _seatsNumber;
            }
        }

        public Bus() { }

        public Bus(int seatsNumber, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            SeatsNumber = seatsNumber;
        }

        public override string GetInfo()
        {
            string busInfo = base.GetInfo();
            return (busInfo + $"Number of seats: {SeatsNumber}");
        }
    }
}