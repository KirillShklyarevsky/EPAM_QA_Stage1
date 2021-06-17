using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that define plane
    /// </summary>
    public class Plane : IFlyable
    {
        const int startSpeed = 200;
        const int acceleration = 10;
        const int accelerationDistance = 10;

        /// <summary>
        /// Method that set and return current position field value
        /// </summary>
        public Coordinate CurrentPosition { get; set; }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="currentPosition"></param>
        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Method for change the value of current position
        /// </summary>
        /// <param name="coordinate"></param>
        public void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public DateTime GetFlyTime(Coordinate coordinate)
        {
            DateTime time = DateTime.Now;
            int speed = startSpeed;
            double flightTime = 0;
            double distance = CurrentPosition.DistanceBetweenTwoPoint(coordinate);

            while (distance > 0)
            {
                flightTime += accelerationDistance / speed;
                speed += acceleration;
                distance -= accelerationDistance;
            }
            flightTime += distance / speed;

            return time.AddHours(flightTime);
        }
    }
}