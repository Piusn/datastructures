using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class QuickSortAlgorithm
    {
        public static void Sort(int[] input)
        {
            QuickSortHelper(input, 0, input.Length - 1);
        }

        public static int Partition(int[] input, int low, int high)
        {
            //var pivot = (low + high) / 2;
            var pivotValue = input[low];
            int i = low;
            int j = high;

            while (i < j)
            {
                if (input[i] <= pivotValue && i < j)
                    i++;

                if (input[j] > pivotValue)
                    j--;

                if (input[j] < input[i] && i < j)
                {
                    int temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                }

            }

            input[low] = input[j];
            input[j] = pivotValue;

            return j;
        }

        public static void QuickSortHelper(int[] input, int low, int high)
        {
            if (low < high)
            {
                //Get the split value for the input
                var splitValue = Partition(input, low, high);

                QuickSortHelper(input, low, splitValue - 1);
                QuickSortHelper(input, splitValue + 1, high);
            }
        }
    }
}
