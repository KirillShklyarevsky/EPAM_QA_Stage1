using ObjectOrientedDesignPrinciples.Interfaces;

namespace ObjectOrientedDesignPrinciples.Commands
{
    public class AveragePriceCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine($"Average price : {CarDealer.GetCarDealer().GetAveragePrice()}");
        }
    }
}