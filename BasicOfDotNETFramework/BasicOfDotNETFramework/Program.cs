using System;

namespace BasicOfDotNETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(ConvertToAnotherSystem(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string ConvertToAnotherSystem(int number, int systemBase)
        {
            if (systemBase > 20 || systemBase < 2)
            {
                throw new ArgumentOutOfRangeException("System base must be in range from 2 to 20");
            }

            if (number == 0 || number == 10)
            {
                return number.ToString();
            }

            string reversedNumberInBaseSystem = String.Empty;
            int residue = 0;

            while (number > 0)
            {
                residue = number % systemBase;
                number = number / systemBase;
                reversedNumberInBaseSystem += ConvertResidueToString(residue);
            }
            

            if (number < 0)
            {
                return $"-" + ReverseString(reversedNumberInBaseSystem);
            }
            else
            {
                return ReverseString(reversedNumberInBaseSystem);
            }
        }

        public static string ConvertResidueToString(int residue)
        {
            string newSymbol = String.Empty;
            if (residue > 10)
            {
                string valuesOver10 = "ABCDEFGIJI";
                return newSymbol += valuesOver10[residue - 10];
            }
            else
            {
                return newSymbol += residue.ToString();
            }
        }

        public static string ReverseString(string reversedNumberInBaseSystem)
        {
            char[] arr = reversedNumberInBaseSystem.ToCharArray();
            Array.Reverse(arr);

            return new String(arr);
        }
    }
}