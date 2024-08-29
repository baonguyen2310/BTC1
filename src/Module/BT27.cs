using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT27
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
        public static int recursiveFn(int n, int current)
        {
            if (current > Math.Sqrt(n)) return 0;
            int tmp = 0;
            if (n % current == 0)
            {
                if (current % 2 == 0) tmp++;
                if (current != (n / current) && (n / current) % 2 == 0)
                {
                    tmp++;
                }
            }
            return tmp + recursiveFn(n, current + 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT27:");
            int input = getValidInput();
            int output = recursiveFn(input, 1);
            printOutput(output);
        }
    }

}