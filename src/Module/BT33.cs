using System;

namespace BTC1.Module
{
    public class BT33
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
            if (n == 1) return Math.Sqrt(2);
            return Math.Sqrt(2 + recursiveFn(n - 1));
        }
        public static void Run()
        {
            Console.WriteLine("BT33:");
            int input = getValidInput();
            double output = recursiveFn(input);
            printOutput(output);
        }
    }

}