using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT31
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
            if (output) Console.WriteLine("n là số nguyên tố");
            else Console.WriteLine("n không là số nguyên tố");
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static bool recursiveFn(int n, int current)
        {
            if (current > Math.Sqrt(n)) return true;
            if (n % current == 0) return false;
            return recursiveFn(n, current + 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT31:");
            int input = getValidInput();
            bool output = recursiveFn(input, 2);
            if (input == 1) output = false;
            printOutput(output);
        }
    }

}