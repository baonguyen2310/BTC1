using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT30
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
        public static void printOutput(bool output)
        {
            if (output) Console.WriteLine("n là số hoàn thiện");
            else Console.WriteLine("n không là số hoàn thiện");
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static bool recursiveFn(int n, int current, int sum)
        {
            if (current > Math.Sqrt(n)) return sum == n;
            if (n % current == 0)
            {
                sum += current;
                if (current != (n / current) && (n / current) < n)
                {
                    sum += n / current;
                }
            }
            return recursiveFn(n, current + 1, sum);
        }
        public static void Run()
        {
            Console.WriteLine("BT30:");
            int input = getValidInput();
            bool output = recursiveFn(input, 1, 0);
            if (input == 1) output = false;
            printOutput(output);
        }
    }

}