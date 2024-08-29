using System;

namespace BTC1.Module
{
    public class BT10V2
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
            if (n == 1) return x;
            int temp = recursiveFn(x, n/2);
            if (n % 2 == 0) return temp*temp;
            return temp*temp*x;
        }
        public static void Run()
        {
            Console.WriteLine("BT10V2:");
            int x = getValidInput("Input x");
            int n = getValidInput("Input n");
            int output = recursiveFn(x, n);
            printOutput(output);
        }
    }

}