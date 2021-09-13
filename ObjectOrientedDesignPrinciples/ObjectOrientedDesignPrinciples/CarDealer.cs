using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedDesignPrinciples
{
    public class CarDealer
    {
        private static CarDealer _carDealer = null;
        private static object _locker = new object();

        private List<Car> _cars;

        private CarDealer()
        {
            _cars = new List<Car>();
        }

        public static CarDealer GetCarDealer()
        {
            lock (_locker)
            {
                if (_carDealer == null)
                {
                    _carDealer = new CarDealer();
                }
                return _carDealer;
            }
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public int GetCountTypes()
        {
            return _cars.GroupBy(x => x.Brand).Count();
        }

        public int GetCountAll()
        {
            return _cars.Sum(x => x.Number);
        }

        public double GetAveragePrice()
        {
            return _cars.Sum(x => x.CostOfOne) / _cars.Count();
        }

        public double GetAveragePriceType(string brand)
        {
            return _cars.Where(x => x.Brand == brand).Sum(x => x.CostOfOne) / _cars.Where(x => x.Brand == brand).Count();
        }
    }
}