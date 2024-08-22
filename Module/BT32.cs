using System;
using System.Collections.Generic;

namespace BTC1.Module
{
    public class BT32
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
            if (output) Console.WriteLine("n là số chính phương");
            else Console.WriteLine("n không là số chính phương");
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static bool recursiveFn(int n, int current)
        {
            if (current > Math.Sqrt(n)) return false;
            if (current * current == n) return true;
            return recursiveFn(n, current + 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT32:");
            int input = getValidInput();
            bool output = recursiveFn(input, 1);
            printOutput(output);
        }
    }

}