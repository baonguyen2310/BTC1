using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT29
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
        public static void printOutput(int output)
        {
            Console.WriteLine("Output: " + output);
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static void recursiveFn(int n, int current, ref int output)
        {
            if (current > Math.Sqrt(n)) return;
            if (n % current == 0)
            {
                if (current % 2 != 0 && output < current) output = current;
                if (current != (n / current) && (n / current) % 2 != 0 && output < (n / current))
                {
                    output = n / current;
                }
            }
            recursiveFn(n, current + 1, ref output);
        }
        public static void Run()
        {
            Console.WriteLine("BT29:");
            int input = getValidInput();
            int output = 1;
            recursiveFn(input, 1, ref output);
            printOutput(output);
        }
    }

}