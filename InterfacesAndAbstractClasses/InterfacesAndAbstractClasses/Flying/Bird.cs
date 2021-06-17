using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that define bird
    /// </summary>
    public class Bird : IFlyable
    {
        /// <summary>
        /// Method that set and return current position field value
        /// </summary>
        public Coordinate CurrentPosition { get; set; }

        /// <summary>
        /// Method that set and return speed field value
        /// </summary>
        public int Speed { get; set; }

        const int minimalSpeed = 0;
        const int maximalSpeed = 20;

        /// <summary>
        /// Constructor initializes class fields and generating random speed
        /// </summary>
        /// <param name="currentPosition"></param>
        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
            Random random = new Random();
            Speed = random.Next(minimalSpeed, maximalSpeed);
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