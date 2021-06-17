using System;

namespace OOP
{
    /// <summary>
    /// Class that define engine
    /// </summary>
    [Serializable]
    public class Engine
    {
        private double _power;
        private double _capacity;
        private string _serialNumber;

        /// <summary>
        /// Method that set and get value of power field
        /// </summary>
        public double Power
        {
            get
            {
                return _power;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _power = value;
            }
        }

        /// <summary>
        /// Method that set and get value of capacity field
        /// </summary>
        public double Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                _capacity = value;
            }
        }

        /// <summary>
        /// Method that set and get value of serial number field
        /// </summary>
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }

            set
            {
                _serialNumber = value ?? throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Method that set and get value of engine type field
        /// </summary>
        public EngineTypes EngineType { get; set; }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Engine() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="power"></param>
        /// <param name="capacity"></param>
        /// <param name="engineType"></param>
        /// <param name="serialNumber"></param>
        public Engine(double power, double capacity, EngineTypes engineType, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            EngineType = engineType;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Engine info: Power: " + Power + " Capacity: " + Capacity
                    + " Type: " + EngineType + " Serial number: " + SerialNumber);
        }
    }
}