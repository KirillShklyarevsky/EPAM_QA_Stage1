using System;

namespace InterfacesAndAbstractClasses
{
    public class Drone : IFlyable
    {
        const double speed = 20;
        const double stopPeriod = 1 / 6;
        const double stopTime = 1 / 60;
        const double maximumRange = 1000;

        public Coordinate CurrentPosition { get; set; }

        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate coordinate)
        {
            if (coordinate.DistanceBetweenTwoPoint(CurrentPosition) > maximumRange)
            {
                throw new ArgumentException();
            }
            CurrentPosition = coordinate;
        }

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