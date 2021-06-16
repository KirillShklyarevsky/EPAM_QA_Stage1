using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public static class Helper
    {
        public static List<VehicleBase> VehiclesWithEngineCapacityMoreThan(double capacity, List<VehicleBase> vehicleBases)
        {
            return vehicleBases.Where(x => x.VehicleEngine.Capacity > capacity).ToList();
        }

        public static List<Engine> EngineTypeSerialNumberCapacityOfTruckAndBus(List<VehicleBase> vehicleBases)
        {
            return vehicleBases.Where(x => x is Truck || x is Bus).Select(x => x.VehicleEngine).ToList();
        }

        public static List<VehicleBase> GroupedByTransmission(List<VehicleBase> vehicleBases)
        {
            return vehicleBases.GroupBy(x => x.VehicleTransmission.TransmissionType).SelectMany(x => x).ToList();
        }
    }
}