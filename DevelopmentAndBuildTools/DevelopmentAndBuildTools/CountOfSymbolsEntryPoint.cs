using System;

namespace DevelopmentAndBuildTools
{
    public class CountOfSymbolsEntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MaxCountOfNonRepeatingSymbolsInARow(args[0]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int MaxCountOfNonRepeatingSymbolsInARow(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException();
            }

            if (line == string.Empty)
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