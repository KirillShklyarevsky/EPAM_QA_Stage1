using System.Collections.Generic;

namespace OOP
{
    class VehicleEntryPoint
    {
        static void Main(string[] args)
        {
            Car car = new Car(5,
                  new Engine(165, 2.2, EngineTypes.Petrol, "GCBDT-1091866"),
                  new Chassis(4, "GX620U1", 500),
                  new Transmission(TransmissionTypes.Manual, 5, "ZF"));

            Truck truck = new Truck(15000,
                  new Engine(300, 10, EngineTypes.Diesel, "AABDT-1866"),
                  new Chassis(6, "620U1", 20000),
                  new Transmission(TransmissionTypes.Manual, 8, "EATOn"));

            Bus bus = new Bus(32,
                  new Engine(180, 6, EngineTypes.Gas, "CCBDT-1091866"),
                  new Chassis(8, "15620U1", 5000),
                  new Transmission(TransmissionTypes.Automatic, 6, "Aisin"));

            Scooter scooter = new Scooter(5,
                  new Engine(60, 0.9, EngineTypes.Electrical, "BBBDT-1091866"),
                  new Chassis(2, "13420U1", 100),
                  new Transmission(TransmissionTypes.Automatic, 4, "Jatco"));

            List<VehicleBase> vehicles = new List<VehicleBase>() { bus, car, truck, scooter };

            Serializer<VehicleBase>.Serialize("VehiclesWithEngineCapacityMoreThan1,5.xml", Helper.VehiclesWithEngineCapacityMoreThan(1.5, vehicles));
            Serializer<Engine>.Serialize("EngineTypeSerialNumberCapacityOfTruckAndBus.xml", Helper.EngineTypeSerialNumberCapacityOfTruckAndBus(vehicles));
            Serializer<VehicleBase>.Serialize("GroupedByTransmission.xml", Helper.GroupedByTransmission(vehicles));
        }
    }
}