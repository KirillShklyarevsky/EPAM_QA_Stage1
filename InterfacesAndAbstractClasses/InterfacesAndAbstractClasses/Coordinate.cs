using System;

namespace InterfacesAndAbstractClasses
{
    /// <summary>
    /// Class that define coordinate
    /// </summary>
    public class Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

        /// <summary>
        /// Method that set and return field x value
        /// </summary>
        public double X
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _x = value;
            }
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Method that set and return field y value
        /// </summary>
        public double Y
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _y = value;
            }
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Method that set and return field z value
        /// </summary>
        public double Z
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _z = value;
            }
            get
            {
                return _z;
            }
        }

        /// <summary>
        /// Constructor for structure coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Method that calculates the distance between 2 points
        /// </summary>
        /// <param name="coordinate"> Coordinates of second point </param>
        /// <returns></returns>
        public double DistanceBetweenTwoPoint(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Pow(X - coordinate.X, 2) + Math.Pow(Y - coordinate.Y, 2) + Math.Pow(Z - coordinate.Z, 2));
        }
    }
}