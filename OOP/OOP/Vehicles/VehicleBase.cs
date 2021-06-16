using System;
using System.Xml.Serialization;

namespace OOP
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [Serializable]
    public abstract class VehicleBase
    {
        public Engine VehicleEngine { get; set; }

        public Chassis VehicleChassis { get; set; }

        public Transmission VehicleTransmission { get; set; }

        public VehicleBase() { }

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