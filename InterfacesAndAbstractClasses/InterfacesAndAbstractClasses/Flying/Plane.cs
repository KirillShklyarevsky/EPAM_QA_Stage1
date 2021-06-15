using System;

namespace InterfacesAndAbstractClasses
{
    public class Plane : IFlyable
    {
        const int startSpeed = 200;
        const int maximumSpeed = 1500;
        const int acceleration = 10;
        const int accelerationDistance = 10;

        public Coordinate CurrentPosition { get; set; }

        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

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