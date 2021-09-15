using System;

namespace DevelopmentAndBuildTools
{
    /// <summary>
    /// Class that contains entry point of program and method for calculating amount of different symbols in a row
    /// </summary>
    public class CountOfSymbolsEntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(SymbolsCounter.GetMaxCountOfNonRepeatingSymbolsInARow(args[0]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}