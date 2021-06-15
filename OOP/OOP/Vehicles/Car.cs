namespace OOP
{
    public class Car : VehicleBase
    {
        public int NumberOfDoors { get; set; }

        public Car(int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"Number of doors: {NumberOfDoors}");
        }
    }
}