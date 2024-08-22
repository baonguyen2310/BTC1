using System;

namespace BTC1.Module
{
    public class BT18
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
        public static void printOutput(float output)
        {
            Console.WriteLine("Output: " + output);
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        public static float recursiveFn(int x, int n)
        {
            if (n == 1) return 1.0f + (float) x*x / 2;
            return (float) ((int) Math.Pow(x, 2*n)) / CommonModule.Factorial(2*n) + recursiveFn(x, n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT18:");
            int x = getValidInput("Input x");
            int n = getValidInput("Input n");
            float output = recursiveFn(x, n);
            printOutput(output);
        }
    }

}