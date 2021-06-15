namespace OOP
{
    public class Scooter : VehicleBase
    {
        public double MaximumSpeed { get; set; }

        public Scooter(int maximumSpeed, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumSpeed = maximumSpeed;
        }

        public override string GetInfo()
        {
            string scooterInfo = base.GetInfo();
            return (scooterInfo + $"Maximum speed: {MaximumSpeed}");
        }
    }
}