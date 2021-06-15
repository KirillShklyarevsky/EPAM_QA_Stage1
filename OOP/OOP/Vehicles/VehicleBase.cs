namespace OOP
{
    public abstract class VehicleBase
    {
        public Engine VehicleEngine { get; set; }

        public Chassis VehicleChassis { get; set; }

        public Transmission VehicleTransmission { get; set; }

        public VehicleBase(Engine engine, Chassis chassis, Transmission transmission)
        {
            VehicleEngine = engine;
            VehicleChassis = chassis;
            VehicleTransmission = transmission;
        }

        virtual public string GetInfo()
        {
            return $"{VehicleEngine.GetInfo()}\n" + $"{VehicleChassis.GetInfo()}\n" + $"{VehicleTransmission.GetInfo()}\n";
        }
    }
}