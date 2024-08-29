using System;

namespace BTC1.Module
{
    public class BT19
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
            if (n == 1) return 1.0f + ((float) x) + (float) x*x*x / 6;
            return (float) ((int) Math.Pow(x, 2*n + 1)) / CommonModule.Factorial(2*n + 1) + recursiveFn(x, n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT19:");
            int x = getValidInput("Input x");
            int n = getValidInput("Input n");
            float output = recursiveFn(x, n);
            printOutput(output);
        }
    }

}