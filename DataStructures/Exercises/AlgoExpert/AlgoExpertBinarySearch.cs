using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertBinarySearch
    {
        public AlgoExpertBinarySearch()
        {
            int[] arr = new[] { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9,89, 6, 3, 1, -5, 4 };
            var value = BinarySearch(arr, 89);
        }
        public int BinarySearch(int[] array, int target)
        {
            Array.Sort(array);
       var index = BinarySearch(array, target, 0, array.Length - 1);

            return index;
        }

        public int BinarySearch(int[] array, int value, int left, int right)
        {
            var mid = (right + left) / 2;

            if (array[mid] == value)
                return mid;

            if (left >= right)
                return -1;

            if (value < array[mid])
            {
                return BinarySearch(array, value, left, mid - 1);
            }
            else
            {
                return BinarySearch(array, value, mid + 1, right);
            }
        }
    }
}
