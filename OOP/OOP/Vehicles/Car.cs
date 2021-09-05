using System;
using OOP.Exceptions;

namespace OOP
{
    /// <summary>
    /// Class that defines the car 
    /// </summary>
    [Serializable]
    public class Car : VehicleBase
    {
        private int _numberOfDoors;

        /// <summary>
        /// Method that set and get value number of doors field
        /// </summary>
        public int NumberOfDoors
        {
            set
            {
                if (value < 1)
                {
                    throw new InitializationException("Unable to initialize the car.");
                }
                _numberOfDoors = value;
            }

            get
            {
                return _numberOfDoors;
            }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Car() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfDoors"> Number of doors in car </param>
        /// <param name="engine"> Engine of car </param>
        /// <param name="chassis"> Chassis of car </param>
        /// <param name="transmission"> Transmission of car </param>
        public Car(int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"Number of doors: {NumberOfDoors}");
        }
    }
}