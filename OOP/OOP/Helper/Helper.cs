using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    /// <summary>
    /// Class that contains methods for parsing list of vehicles
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Method that return list of vehicles that contain vehicles with engine capacity more than given capacity
        /// </summary>
        /// <param name="capacity"> Capacity of engine </param>
        /// <param name="vehicleBases"> List of vehicles </param>
        /// <returns></returns>
        public static List<VehicleBase> GetListOfVehiclesWithEngineCapacityMoreThan(double capacity, List<VehicleBase> vehicleBases)
        {
            return vehicleBases.Where(x => x.VehicleEngine.Capacity > capacity).ToList();
        }

        /// <summary>
        /// Method that return list of engines of truck and bus
        /// </summary>
        /// <param name="vehicleBases"> List of vehicles </param>
        /// <returns></returns>
        public static List<Engine> GetListOfEngineTypeSerialNumberCapacityOfTruckAndBus(List<VehicleBase> vehicleBases)
        {
            return vehicleBases.Where(x => x is Truck || x is Bus).Select(x => x.VehicleEngine).ToList();
        }

        /// <summary>
        /// Method that return list of vehicles grouped by transmission
        /// </summary>
        /// <param name="vehicleBases"> List of vehicles </param>
        /// <returns></returns>
        public static List<VehicleBase> GetListOfGroupedByTransmission(List<VehicleBase> vehicleBases)
        {
            return vehicleBases.GroupBy(x => x.VehicleTransmission.TransmissionType).SelectMany(x => x).ToList();
        }
    }
}