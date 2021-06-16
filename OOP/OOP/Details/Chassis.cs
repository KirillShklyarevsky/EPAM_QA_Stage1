using System;

namespace OOP
{
    [Serializable]
    public class Chassis
    {
        private double _numberOfWheels;
        private string _serialNumber;
        private double _permissibleLoad;

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

        public Chassis() { }

        public Chassis(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumber;
            PermissibleLoad = permissibleLoad;
        }

        public string GetInfo()
        {
            return ("Chassis info: Number of wheels: " + NumberOfWheels + " Serial number: " + SerialNumber
                    + " Permissible load: " + PermissibleLoad);
        }
    }
}