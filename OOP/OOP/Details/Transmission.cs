using System;

namespace OOP
{
    [Serializable]
    public class Transmission
    {
        private int _numberOfGears;
        private string _manufacturer;

        public TransmissionTypes TransmissionType { get; set; }

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

        public Transmission() { }

        public Transmission(TransmissionTypes transmissionType, int numberOfGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public string GetInfo()
        {
            return ("Transmisssion info: Transmission type: " + TransmissionType + " Number of gears: " + NumberOfGears
                    + " Manufacturer: " + Manufacturer);
        }
    }
}