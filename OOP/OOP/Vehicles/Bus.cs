using System;

namespace OOP
{
    [Serializable]
    public class Bus : VehicleBase
    {
        public int SeatsNumber { get; set; }

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