using System;

namespace DevelopmentAndBuildTools
{
    public static class SymbolsCounter
    {
        /// <summary>
        /// Method for calculating amount of different symbols in a row
        /// </summary>
        /// <param name="line"> Calculated string  </param>
        /// <returns></returns>
        public static int GetMaxCountOfNonRepeatingSymbolsInARow(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line));
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

        public static int GetMaxCountOfNonRepeatingLatinLettersInARow(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line));
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
                if (currentSymbol != previousSymbol && IsSymbolIsLatinLetter(currentSymbol) && IsSymbolIsLatinLetter(previousSymbol))
                {
                    count++;
                    previousSymbol = currentSymbol;
                }
                else
                {
                    if (!IsSymbolIsLatinLetter(currentSymbol))
                    {
                        count = 0;
                    }
                    else
                    {
                        count = 1;
                    }

                    previousSymbol = currentSymbol;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            return maxCount;
        }

        private static bool IsSymbolIsLatinLetter(char symbol)
        {
            return ((symbol >= 65 && symbol <= 90) || (symbol >= 90 && symbol <= 122));
        }

        public static int GetMaxCountOfNonRepeatingNumbersInARow(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line));
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
                if (currentSymbol != previousSymbol && char.IsDigit(currentSymbol) && char.IsDigit(previousSymbol))
                {
                    count++;
                    previousSymbol = currentSymbol;
                }
                else
                {
                    if (!char.IsDigit(currentSymbol))
                    {
                        count = 0;
                    }
                    else
                    {
                        count = 1;
                    }

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