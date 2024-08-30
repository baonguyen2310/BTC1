using System;

namespace BTC1.Module
{
    public class BT43
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
        // public static int recursiveFn(int n, int count)
        // {
        //     if (n == 0) return count;
        //     return recursiveFn(n / 10, count + 1); // hoặc dùng ++count, không dùng count++
        // }

        public static int recursiveFn(int n)
        {
            if (n == 0) return 0;
            return 1 + recursiveFn(n / 10);
        }
        public static void Run()
        {
            Console.WriteLine("BT43:");
            int input = getValidInput();
            int output = recursiveFn(input);
            printOutput(output);
        }
    }

}