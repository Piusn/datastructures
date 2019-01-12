using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class DynamicProgramming
    {
        private static int[] computed;

        public static void Run()
        {
            int n = 50;
            computed = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                computed[i] = -1;
            }

            Console.WriteLine(StringSumCount(n));

            var permutations = StringSumCountBottomUp(n);
        }
        private static int StringSumCount(int n)
        {
            if (n == 0)
                return 1;

            if (n < 1)
                return 0;

            if (computed[n] != -1)
                return computed[n];

            int sum = 0;
            sum += StringSumCount(n - 1);

            sum += StringSumCount(n - 2);
            sum += StringSumCount(n - 3);

            computed[n] = sum;
            return sum;
        }

        public static int StringSumCountBottomUp(int n)
        {
            int[] computed = new int [n + 1];
            computed[0] = 0;
            computed[1] = 1;
            computed[2] = 2;
            computed[3] = 4;

            for (int i = 4; i < n+1; i++)
            {
                computed[i] = computed[i - 1] + computed[i - 2] + computed[i - 3];
            }

            return computed[n];
        }
    }
}
