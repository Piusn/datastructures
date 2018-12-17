using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class ArrayExercise
    {
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
    }
}
