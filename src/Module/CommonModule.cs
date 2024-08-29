using System;

namespace BTC1.Module
{
    class CommonModule {
        public static int SumRecursive(int n)
        {
            if (n == 1) return 1;
            return n + SumRecursive(n - 1);
        }
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}