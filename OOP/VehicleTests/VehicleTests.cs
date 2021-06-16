using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP;
using System;

namespace VehicleTests
{
    [TestClass]
    public class VehicleTests
    {
        [DataRow(-1, 100, EngineTypes.Diesel, "1106D-E66TA")]
        [DataRow(100, -1, EngineTypes.Diesel, "1106D-E66TA")]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EngineThrowExceptionIfPowerOrCapacityNotValid(double power, double capacity, EngineTypes engineType, string serialNumber)
        {
            Engine engine = new Engine(power, capacity, engineType, serialNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EngineThrowExceptionIfSerialNumberIsNull()
        {
            Engine engine = new Engine(100, 10, EngineTypes.Diesel, null);
        }

        [DataRow(-1, "QSB4-5", 1000)]
        [DataRow(4, "QSB4-5", -1)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChassisThrowExceptionIfArgumetsNotValid(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            Chassis chassis = new Chassis(numberOfWheels, serialNumber, permissibleLoad);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChassisThrowExceptionIfSerialNumberIsNull()
        {
            Chassis chassis = new Chassis(4, null, 1000);
        }

        [DataRow(TransmissionTypes.Automatic, -1, "Jatco")]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TransmissonThrowExceptionIfArgumetsNotValid(TransmissionTypes transmissionType, int numberOfGears, string manufacture)
        {
            Transmission transmission = new Transmission(transmissionType, numberOfGears, manufacture);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TransmissionThrowExceptionIfManufacturerIsNull()
        {
            Transmission transmission = new Transmission(TransmissionTypes.Automatic, 5, null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarThrowExceptionIfArgumetsNotValid()
        {
            Car car = new Car(-1,
                  new Engine(165, 2.2, EngineTypes.Petrol, "GCBDT-1091866"),
                  new Chassis(4, "GX620U1", 500),
                  new Transmission(TransmissionTypes.Manual, 5, "ZF"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TruckThrowExceptionIfArgumetsNotValid()
        {
            Truck truck = new Truck(-1,
                  new Engine(300, 10, EngineTypes.Diesel, "AABDT-1866"),
                  new Chassis(6, "620U1", 20000),
                  new Transmission(TransmissionTypes.Manual, 8, "EATOn"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void BusThrowExceptionIfArgumetsNotValid()
        {
            Bus bus = new Bus(-1,
                  new Engine(180, 6, EngineTypes.Gas, "CCBDT-1091866"),
                  new Chassis(8, "15620U1", 5000),
                  new Transmission(TransmissionTypes.Automatic, 6, "Aisin"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ScooterThrowExceptionIfArgumetsNotValid()
        {
            Scooter scooter = new Scooter(-1,
                  new Engine(60, 0.9, EngineTypes.Electrical, "BBBDT-1091866"),
                  new Chassis(2, "13420U1", 100),
                  new Transmission(TransmissionTypes.Automatic, 4, "Jatco"));
        }
    }
}