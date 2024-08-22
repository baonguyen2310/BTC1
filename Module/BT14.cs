using System;

namespace BTC1.Module
{
    public class BT14
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
        public static int recursiveFn(int x, int n)
        {
            if (n == 0) return x;
            return (int) Math.Pow(x, 2*n+1) + recursiveFn(x, n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT14:");
            int x = getValidInput("Input x");
            int n = getValidInput("Input n");
            int output = recursiveFn(x, n);
            printOutput(output);
        }
    }

}