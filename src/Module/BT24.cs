using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT24
    {
        static int getValidInput(string inputMessage = "Input n")
        {
            Console.Write(inputMessage + ": ");
            string input = Console.ReadLine();
            while (!checkValidInput(input)) {
                Console.Write(inputMessage + " again: ");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
        public static void printOutput(List<int> factors)
        {
            Console.WriteLine("Các ước số lẻ: ");
            factors.Sort();

            foreach (int factor in factors) {
                Console.WriteLine(factor);
            }
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static void recursiveFn(int n, int current, List<int> factors)
        {
            if (current > Math.Sqrt(n)) return;
            if (n % current == 0)
            {
                if (current % 2 != 0) factors.Add(current);
                if (current != (n / current) && (n / current) % 2 != 0)
                {
                    factors.Add(n / current);
                }
            }
            recursiveFn(n, current + 1, factors);
        }
        public static void Run()
        {
            Console.WriteLine("BT24:");
            int input = getValidInput();
            List<int> factors = new List<int>();
            recursiveFn(input, 1, factors);
            printOutput(factors);
        }
    }

}