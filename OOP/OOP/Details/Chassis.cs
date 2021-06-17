using System;

namespace OOP
{
    /// <summary>
    /// Class that define chassis
    /// </summary>
    [Serializable]
    public class Chassis
    {
        private double _numberOfWheels;
        private string _serialNumber;
        private double _permissibleLoad;

        /// <summary>
        /// Method that set and get value of number of wheels field
        /// </summary>
        public double NumberOfWheels
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _numberOfWheels = value;
            }

            get
            {
                return _numberOfWheels;
            }
        }

        /// <summary>
        /// Method that set and get value of serial number field
        /// </summary>
        public string SerialNumber
        {
            set
            {
                _serialNumber = value ?? throw new ArgumentNullException();
            }

            get
            {
                return _serialNumber;
            }
        }

        /// <summary>
        /// Method that set and get value of permissible field
        /// </summary>
        public double PermissibleLoad
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _permissibleLoad = value;
            }

            get
            {
                return _permissibleLoad;
            }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Chassis() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfWheels"></param>
        /// <param name="serialNumber"></param>
        /// <param name="permissibleLoad"></param>
        public Chassis(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumber;
            PermissibleLoad = permissibleLoad;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Chassis info: Number of wheels: " + NumberOfWheels + " Serial number: " + SerialNumber
                    + " Permissible load: " + PermissibleLoad);
        }
    }
}