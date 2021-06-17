using System;

namespace OOP
{
    /// <summary>
    /// Class that defines the bus 
    /// </summary>
    [Serializable]
    public class Bus : VehicleBase
    {
        private int _seatsNumber;

        /// <summary>
        /// Method that set and get value of seats number field
        /// </summary>
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

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Bus() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="seatsNumber"> Number of seats in bus </param>
        /// <param name="engine"> Engine of bus </param>
        /// <param name="chassis"> Chassis of bus </param>
        /// <param name="transmission"> Transmission of bus </param>
        public Bus(int seatsNumber, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            SeatsNumber = seatsNumber;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string busInfo = base.GetInfo();
            return (busInfo + $"Number of seats: {SeatsNumber}");
        }
    }
}