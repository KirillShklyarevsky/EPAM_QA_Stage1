using System;
using OOP.Exceptions;

namespace OOP
{
    /// <summary>
    /// Class that defines the truck 
    /// </summary>
    [Serializable]
    public class Truck : VehicleBase
    {
        private double _maximumLoad;

        /// <summary>
        /// Method that set and get value of maximum load field
        /// </summary>
        public double MaximumLoad
        {
            set
            {
                if (value < 0)
                {
                    throw new InitializationException("truck");
                }
                _maximumLoad = value;
            }

            get
            {
                return _maximumLoad;
            }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Truck() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumLoad"> Maximum load of truck </param>
        /// <param name="engine"> Engine of truck </param>
        /// <param name="chassis"> Chassis of truck </param>
        /// <param name="transmission"> Transmission of truck </param>
        public Truck(double maximumLoad, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumLoad = maximumLoad;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string truckInfo = base.GetInfo();
            return (truckInfo + $"Maximun load: {MaximumLoad}");
        }
    }
}