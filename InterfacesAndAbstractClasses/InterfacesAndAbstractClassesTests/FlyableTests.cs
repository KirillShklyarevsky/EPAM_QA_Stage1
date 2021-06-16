using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfacesAndAbstractClasses;
using System;

namespace InterfacesAndAbstractClassesTests
{
    [TestClass]
    public class FlyableTests
    {
        [TestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        [ExpectedException(typeof(ArgumentException))]
        public void CoordinateThrowExceptionTest(double x, double y, double z)
        {
            Coordinate coordinate = new Coordinate(x, y, z);
        }

        [TestMethod]
        public void DistanceBetweenTwoPointTest()
        {
            Coordinate coordinate1 = new Coordinate(0, 0, 0);
            Coordinate coordinate2 = new Coordinate(1, 1, 1);
            double expected = Math.Sqrt(3);

            double actual = coordinate1.DistanceBetweenTwoPoint(coordinate2);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DroneFlyToThrowExceptionTest()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.FlyTo(new Coordinate(1500, 1500, 1500));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DroneGetFlyTimeThrowExceptionTest()
        {
            Drone drone = new Drone(new Coordinate(1, 1, 1));
            drone.GetFlyTime(new Coordinate(1500, 1500, 1500));
        }
    }
}