using System;

namespace DevelopmentAndBuildTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxCountOfNonRepeatingSymbolsInARow(args[0]));
        }

        static int MaxCountOfNonRepeatingSymbolsInARow(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return 0;
            }

            int maxCount = 0;
            int count = 0;
            char previousSymbol = line[0];

            foreach (char currentSymbol in line)
            {
                if (currentSymbol != previousSymbol)
                {
                    count++;
                    previousSymbol = currentSymbol;
                }
                else
                {
                    count = 1;
                    previousSymbol = currentSymbol;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }
    }
}