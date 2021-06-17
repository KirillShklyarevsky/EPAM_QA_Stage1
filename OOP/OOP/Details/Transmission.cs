using System;

namespace OOP
{
    /// <summary>
    /// Class that define transmission
    /// </summary>
    [Serializable]
    public class Transmission
    {
        private int _numberOfGears;
        private string _manufacturer;

        /// <summary>
        /// Method that set and get value of transmission type field
        /// </summary>
        public TransmissionTypes TransmissionType { get; set; }

        /// <summary>
        /// Method that set and get value number of gears field
        /// </summary>
        public int NumberOfGears
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _numberOfGears = value;
            }

            get
            {
                return _numberOfGears;
            }
        }

        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
        public string Manufacturer
        {
            set
            {
                _manufacturer = value ?? throw new ArgumentNullException();
            }

            get
            {
                return _manufacturer;
            }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Transmission() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="transmissionType"></param>
        /// <param name="numberOfGears"></param>
        /// <param name="manufacturer"></param>
        public Transmission(TransmissionTypes transmissionType, int numberOfGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Transmisssion info: Transmission type: " + TransmissionType + " Number of gears: " + NumberOfGears
                    + " Manufacturer: " + Manufacturer);
        }
    }
}