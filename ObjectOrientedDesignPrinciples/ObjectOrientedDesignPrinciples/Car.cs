namespace ObjectOrientedDesignPrinciples
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Number { get; set; }

        public double CostOfOne { get; set; }

        public Car(string brand, string model, int number, double costOfOne)
        {
            Brand = brand;
            Model = model;
            Number = number;
            CostOfOne = costOfOne;
        }
    }
}
