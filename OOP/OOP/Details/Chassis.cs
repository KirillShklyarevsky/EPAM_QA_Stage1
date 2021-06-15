namespace OOP
{
    public class Chassis
    {
        public int NumberOfWheels { get; set; }

        public string SerialNumber { get; set; }

        public double PermissibleLoad { get; set; }

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