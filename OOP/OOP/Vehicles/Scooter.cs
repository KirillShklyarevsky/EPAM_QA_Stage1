using System;
using OOP.Exceptions;

namespace OOP
{
    /// <summary>
    /// Class that defines the scooter 
    /// </summary>
    [Serializable]
    public class Scooter : VehicleBase
    {
        private double _maximumSpeed;

        /// <summary>
        /// Method that set and get value of maximum speed field
        /// </summary>
        public double MaximumSpeed
        {
            set
            {
                if (value < 0)
                {
                    throw new InitializationException("Unable to initialize the scooter.");
                }
                _maximumSpeed = value;
            }

            get
            {
                return _maximumSpeed;
            }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Scooter() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumSpeed"> Maximum speed of scooter </param>
        /// <param name="engine"> Engine of scooter </param>
        /// <param name="chassis"> Chassis of scooter </param>
        /// <param name="transmission"> Transmission of scooter </param>
        public Scooter(int maximumSpeed, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumSpeed = maximumSpeed;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string scooterInfo = base.GetInfo();
            return (scooterInfo + $"Maximum speed: {MaximumSpeed}");
        }
    }
}