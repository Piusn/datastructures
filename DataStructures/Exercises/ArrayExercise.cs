using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class ArrayExercise
    {
        #region Check if array is sorted

        public static bool IsSorted(int[] arr, int start)
        {
            if (arr.Length == 1 || start == arr.Length)
            {
                return true;
            }
            else
            {
                if (arr[start - 1] <= arr[start])
                {
                    return IsSorted(arr, start + 1);
                }

                return false;
            }

        }

        #endregion

        #region Find the Maximum SubArray (Kadane's algorithm) (Largest Contigous Subarray)

        public static void FindMaximumSubarray(int[] input)
        {
            if (input == null || input.Length == 0)
                return;

            int search = 0;
            int startIndex = 0;
            int endIndex = 0;

            int maximum_sum_so_far = 0;
            int maximum_at_index = 0;

            //Start iterating the input
            for (int i = 0; i < input.Length; i++)
            {
                //value it i
                var currentValue = input[i];

                maximum_at_index += currentValue;

                if (maximum_at_index > maximum_sum_so_far)
                {
                    maximum_sum_so_far = maximum_at_index;
                    endIndex = i;
                }

                if (maximum_at_index < 0)
                {
                    maximum_at_index = 0;
                    //startIndex start next index since at this index we can not get the maximum.
                    search = i + 1;
                }
            }
        }

        #endregion
    }
}
