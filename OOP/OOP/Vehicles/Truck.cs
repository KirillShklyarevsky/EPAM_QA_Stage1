namespace OOP
{
    public class Truck : VehicleBase
    {
        public double MaximumLoad { get; set; }

        public Truck(double maximumLoad, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumLoad = maximumLoad;
        }

        public override string GetInfo()
        {
            string truckInfo = base.GetInfo();
            return (truckInfo + $"Maximun load: {MaximumLoad}");
        }
    }
}