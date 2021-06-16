using System;

namespace InterfacesAndAbstractClasses
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);

        DateTime GetFlyTime(Coordinate coordinate);
    }
}