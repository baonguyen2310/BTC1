using System;

namespace BTC1.Module
{
    public class BT42
    {
        public static int getValidInput(string inputMessage = "Input n")
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
        public static int recursiveFn(int n, int k, int sum)
        {
            if (sum + k >= n) return sum;
            return recursiveFn(n, k + 1, sum + k);
        }
        public static void Run()
        {
            Console.WriteLine("BT42:");
            int input = getValidInput();
            int output = recursiveFn(input, 1, 0);
            printOutput(output);
        }
    }

}