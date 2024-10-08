using System;

namespace BTC1.Module
{
    public class BT7
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
        public static float recursiveFn(int n)
        {
            if (n == 1) return (float) 1/2;
            return (float) n/(n+1) + recursiveFn(n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT7:");
            int input = getValidInput();
            float output = recursiveFn(input);
            printOutput(output);
        }
    }

}