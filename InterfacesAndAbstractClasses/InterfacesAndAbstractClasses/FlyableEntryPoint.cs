using System;

namespace InterfacesAndAbstractClasses
{
    class FlyableEntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Bird bird = new Bird(new Coordinate(10, 10, 10));
                Drone drone = new Drone(new Coordinate(10, 10, 10));
                Plane plane = new Plane(new Coordinate(10, 10, 10));

                Console.WriteLine($"Fly time of bird: {bird.GetFlyTime(new Coordinate(500, 500, 500))}");
                Console.WriteLine($"Fly time of drone: {drone.GetFlyTime(new Coordinate(500, 500, 500))}");
                Console.WriteLine($"Fly time of Plane: {plane.GetFlyTime(new Coordinate(500, 500, 500))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}