using System;
using System.Xml.Serialization;

namespace OOP
{
    /// <summary>
    /// Abstract class that define vehicle
    /// </summary>
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [Serializable]
    public abstract class VehicleBase
    {
        private int _id = 1;

        public Engine VehicleEngine { get; set; }

        public Chassis VehicleChassis { get; set; }

        public Transmission VehicleTransmission { get; set; }

        public int ID { get; set; }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public VehicleBase() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="engine"> Engine of vehicle </param>
        /// <param name="chassis"> Chassis of vehicle </param>
        /// <param name="transmission"> Transmission of vehicle </param>
        public VehicleBase(Engine engine, Chassis chassis, Transmission transmission)
        {
            VehicleEngine = engine;
            VehicleChassis = chassis;
            VehicleTransmission = transmission;
            ID = _id++;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        virtual public string GetInfo()
        {
            return $"{VehicleEngine.GetInfo()}\n" + $"{VehicleChassis.GetInfo()}\n" + $"{VehicleTransmission.GetInfo()}\n";
        }
    }
}