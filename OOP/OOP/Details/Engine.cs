using System;

namespace OOP
{
    [Serializable]
    public class Engine
    {
        private double _power;
        private double _capacity;
        private string _serialNumber;

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

        public EngineTypes EngineType { get; set; }

        public Engine() { }

        public Engine(double power, double capacity, EngineTypes engineType, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            EngineType = engineType;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            return ("Engine info: Power: " + Power + " Capacity: " + Capacity
                    + " Type: " + EngineType + " Serial number: " + SerialNumber);
        }
    }
}