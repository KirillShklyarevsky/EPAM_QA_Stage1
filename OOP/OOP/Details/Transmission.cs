namespace OOP
{
    public class Transmission
    {
        public TransmissionTypes TransmissionType { get; set; }

        public int NumberOfGears { get; set; }

        public string Manufacturer { get; set; }

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