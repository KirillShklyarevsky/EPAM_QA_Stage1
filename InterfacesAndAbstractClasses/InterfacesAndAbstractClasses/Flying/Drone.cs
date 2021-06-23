using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that define drone
    /// </summary>
    public class Drone : IFlyable
    {
        const double speed = 20;
        const double stopPeriod = 1 / 6;
        const double stopTime = 1 / 60;
        const double maximumRange = 1000;

        /// <summary>
        /// Method that set and return current position field value
        /// </summary>
        public Coordinate CurrentPosition { get; set; }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="currentPosition"></param>
        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Method for change the value of current position
        /// </summary>
        /// <param name="coordinate"></param>
        public void FlyTo(Coordinate coordinate)
        {
            if (coordinate.DistanceBetweenTwoPoint(CurrentPosition) > maximumRange)
            {
                throw new ArgumentException();
            }
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public DateTime GetFlyTime(Coordinate coordinate)
        {
            double distance = CurrentPosition.DistanceBetweenTwoPoint(coordinate);

            if (distance > maximumRange)
            {
                throw new ArgumentException();
            }

            double stopDistance = speed * stopPeriod;
            int numberOfStops = (int)(distance / stopDistance);
            double timeForTrip = distance / speed + numberOfStops * stopTime;
            DateTime timeNow = DateTime.Now;
            return timeNow.AddHours(timeForTrip);
        }
    }
}