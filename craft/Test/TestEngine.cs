// TestEngine.Test1(BT1.recursiveFn, BT1_TestCases.testCasesInput, BT1_TestCases.testCasesOutput);
// TestEngine.Test1(BT2.recursiveFn, BT2_TestCases.testCasesInput, BT2_TestCases.testCasesOutput);
// TestEngine.Test2(BT3.recursiveFn, BT3_TestCases.testCasesInput, BT3_TestCases.testCasesOutput);
// TestEngine.Test3(BT10.recursiveFn, BT10_TestCases.testCasesInput, BT10_TestCases.testCasesOutput);
// TestEngine.Test3(BT10V2.recursiveFn, BT10_TestCases.testCasesInput, BT10_TestCases.testCasesOutput);

using System;

namespace BTC1.Test
{
    class TestEngine {
        public static void Test1 (
            Func<int, int> fn,
            int[] testCasesInput,
            int[] testCasesOutput,
            bool showDetail = false
        )
        {
            int acceptedCount = 0;

            for (int i = 0; i < testCasesInput.Length; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Test Case " + (i+1) + ":");
                if (showDetail) {
                    Console.WriteLine("Input: " + testCasesInput[i]);
                    Console.WriteLine("Output: " + testCasesOutput[i]);
                }
                int result = fn(testCasesInput[i]);
                Console.WriteLine("Result: " + result);
                if (result == testCasesOutput[i]) {
                    acceptedCount++;
                    Console.WriteLine("ACCEPTED");
                } else {
                    Console.WriteLine("WRONG ANSWER");
                }
            }

            float accuracy = (float) acceptedCount / testCasesInput.Length;
            Console.WriteLine("----------------------");
            Console.WriteLine("Accuracy: " + accuracy);
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }

        public static void Test2 (
            Func<int, float> fn,
            int[] testCasesInput,
            float[] testCasesOutput,
            bool showDetail = false
        )
        {
            int acceptedCount = 0;
            const float epsilon = 1e-6f;

            for (int i = 0; i < testCasesInput.Length; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Test Case " + (i+1) + ":");
                if (showDetail) {
                    Console.WriteLine("Input: " + testCasesInput[i]);
                    Console.WriteLine("Output: " + testCasesOutput[i]);
                }
                float result = fn(testCasesInput[i]);
                Console.WriteLine("Result: " + result);
                if (Math.Abs(result - testCasesOutput[i]) < epsilon) {
                    acceptedCount++;
                    Console.WriteLine("ACCEPTED");
                } else {
                    Console.WriteLine("WRONG ANSWER");
                }
            }

            float accuracy = (float) acceptedCount / testCasesInput.Length;
            Console.WriteLine("----------------------");
            Console.WriteLine("Accuracy: " + accuracy);
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }

        public static void Test3 (
            Func<int, int, int> fn,
            int[,] testCasesInput,
            int[] testCasesOutput,
            bool showDetail = false
        )
        {
            int acceptedCount = 0;

            for (int i = 0; i < testCasesOutput.Length; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Test Case " + (i+1) + ":");
                if (showDetail) {
                    Console.WriteLine("Input: " + testCasesInput[0,i]);
                    Console.WriteLine("Output: " + testCasesOutput[i]);
                }
                int result = fn(testCasesInput[0,i], testCasesInput[1,i]);
                Console.WriteLine("Result: " + result);
                if (result == testCasesOutput[i]) {
                    acceptedCount++;
                    Console.WriteLine("ACCEPTED");
                } else {
                    Console.WriteLine("WRONG ANSWER");
                }
            }

            float accuracy = (float) acceptedCount / testCasesOutput.Length;
            Console.WriteLine("----------------------");
            Console.WriteLine("Accuracy: " + accuracy);
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }
    }
}