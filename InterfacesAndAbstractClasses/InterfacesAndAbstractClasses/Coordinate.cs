using System;

namespace InterfacesAndAbstractClasses
{
    public class Coordinate
    {
        private double _x;
        private double _y;
        private double _z;

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

        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceBetweenTwoPoint(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Pow(X - coordinate.X, 2) + Math.Pow(Y - coordinate.Y, 2) + Math.Pow(Z - coordinate.Z, 2));
        }
    }
}