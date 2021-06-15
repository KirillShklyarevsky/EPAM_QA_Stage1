using System;

namespace InterfacesAndAbstractClasses
{
    public class Coordinate
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

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