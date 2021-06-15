namespace OOP
{
    public class Engine
    {
        public double Power { get; set; }

        public double Capacity { get; set; }

        public EngineTypes EngineType { get; set; }

        public string SerialNumber { get; set; }
        
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