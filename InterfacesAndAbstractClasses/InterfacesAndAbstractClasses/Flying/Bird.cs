using System;

namespace InterfacesAndAbstractClasses
{
    public class Bird : IFlyable
    {
        public Coordinate CurrentPosition { get; set; }
        public int Speed { get; set; }

        const int minimalSpeed = 0;
        const int maximalSpeed = 20;

        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            Random random = new Random();
            Speed = random.Next(minimalSpeed, maximalSpeed);
        }

        public void FlyTo(Coordinate coordinate)
        {
            CurrentPosition = coordinate;
        }

        public DateTime GetFlyTime(Coordinate coordinate)
        {
            if (Speed == minimalSpeed)
            {
                throw new ArgumentException();
            }
            else
            {
                DateTime time = DateTime.Now;
                return time.AddHours(coordinate.DistanceBetweenTwoPoint(CurrentPosition) / Speed);
            }
        }
    }
}