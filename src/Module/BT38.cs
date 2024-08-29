using System;

namespace BTC1.Module
{
    public class BT38
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
        public static void printOutput(double output)
        {
            Console.WriteLine("Output: " + output);
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static double recursiveFn(int n)
        {
            if (n == 1) return Math.Sqrt(1);
            return Math.Pow(n + recursiveFn(n-1), 1.0 / (n + 1));
        }
        public static void Run()
        {
            Console.WriteLine("BT38:");
            int input = getValidInput();
            double output = recursiveFn(input);
            printOutput(output);
        }
    }

}