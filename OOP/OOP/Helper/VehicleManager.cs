using System;
using System.Collections.Generic;
using System.Linq;
using OOP.Exceptions;
using System.Reflection;

namespace OOP
{
    public class VehicleManager
    {
        public List<VehicleBase> Vehicles { get; set; }

        public VehicleManager(List<VehicleBase> vehicles)
        {
            Vehicles = vehicles;
        }

        public bool IsContain(VehicleBase vehicle)
        {
            return Vehicles.Select(x => x.Equals(vehicle)).Contains(true);
        }

        public void Add(VehicleBase vehicle)
        {
            if (!IsContain(vehicle))
            {
                throw new AddException("Unable to add new car model");
            }

            Vehicles.Add(vehicle);
        }

        public List<VehicleBase> GetAutoByParameter(string parameter, string value)
        {
            if (Vehicles.Select(x => GetPropertyByName(parameter, x)).Where(p => !(p is null)).Count() == 0)
            {
                throw new GetAutoByParameterException("Unable to find a model with such parameter");
            }

            return Vehicles.Where(x => GetPropertyValue(parameter, x) == value).ToList();
        }

        private string GetPropertyValue(string parameter, VehicleBase vehicle)
        {
            PropertyInfo property = GetPropertyByName(parameter, vehicle);

            if (property is null)
            {
                return null;
            }

            return property.GetValue(vehicle).ToString();
        }

        private PropertyInfo GetPropertyByName(string parameter, VehicleBase vehicle)
        {
            return vehicle.GetType().GetProperty(parameter);
        }

        public void UpdateAuto(int id, string propertyName, VehicleBase vehicle)
        {
            if (!Vehicles.Select(x => x.ID).Contains(id))
            {
                throw new UpdateAutoException("The car with current ID doesn't exist");
            }

            Vehicles[id] = vehicle;
        }

        public void RemoveAuto(int id)
        {
            if (!Vehicles.Select(x => x.ID).Contains(id))
            {
                throw new UpdateAutoException("The car with current ID doesn't exist");
            }

            Vehicles.RemoveAt(id);
        }
    }
}