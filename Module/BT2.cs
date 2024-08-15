using System;

namespace BTC1.Module
{
    class BT2
    {
        static int getValidInput()
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            while (!checkValidInput(input)) {
                Console.Write("Input again: ");
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
        static int sumRecursive(int n)
        {
            if (n == 1) return 1;
            else return n*n + sumRecursive(n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT2:");
            int input = getValidInput();
            int output = sumRecursive(input);
            printOutput(output);
        }
    }

}