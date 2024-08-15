using System;

namespace BTC1.Module
{
    class BT5
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
            if (n == 0) return 1;
            else return (float) 1/(2*n + 1) + sumRecursive(n - 1);
        }
        public static void Run()
        {
            Console.WriteLine("BT5:");
            int input = getValidInput();
            float output = sumRecursive(input);
            printOutput(output);
        }
    }

}