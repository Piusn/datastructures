using System;
using System.Collections.Generic;

namespace DataStructures.Exercises
{
    public class AllSubsets
    {
        public static void GetAllSubsets(int[] input)
        {
            List<int> subset = new List<int>();
            Helper(input, 0, subset);
        }

        private static void Print(List<int> subset)
        {
            Console.WriteLine(string.Join(",",subset));
        }

        private static void Helper(int[] input, int index, List<int> subset)
        {
            if (index == input.Length)
            {
                Print(subset);
            }
            else
            {
                var current = input[index];
                subset.Add(current);
                Helper(input, index + 1, subset);
                subset.Remove(current);
                Helper(input, index + 1, subset);
            }
        }
    }
}