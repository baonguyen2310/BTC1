using System;

namespace BTC1.Module
{
    class BT3
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
        public static void printOutput(float output)
        {
            Console.WriteLine("Output: " + output);
        }
        static bool checkValidInput(string input)
        {
            int n;
            return int.TryParse(input, out n) && n > 0;
        }
        static float sumRecursive(int n)
        {
            if (n == 1) return 1;
            else return (float) 1/n + sumRecursive(n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT3:");
            int input = getValidInput();
            float output = sumRecursive(input);
            printOutput(output);
        }
    }

}