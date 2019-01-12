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

        public static int BinarySearch(int[] arr, int key, int low, int high)
        {
            if (low > high)
                return -1;
            //add the index
            int mid = low + (high - low) / 2;

            if (arr[mid] == key)
                return mid;

            if (arr[mid] > key)
            {
                return BinarySearch(arr, key, low, mid - 1);
            }
            else
            {
                return BinarySearch(arr, key, mid + 1, high);
            }
        }

        public static void ReverseArray(int[] input, int n)
        {
            ReverseArray(input, 0, input.Length - 1);
            ReverseArray(input, 0, n - 1);
            ReverseArray(input, n, input.Length - 1);
        }
        private static void ReverseArray(int[] input, int start, int end)
        {
            //1 2 3 4
            //4 2 3 1
            //4 3 2 1
            while (start < end)
            {
                var temp = input[start];
                input[start] = input[end];
                input[end] = temp;

                start++;
                end--;
            }
        }

        public static void FindLowHighIndex(int[] input)
        {
            var mid = (input.Length -1 - 0) / 2;
            var low = FindLowHighIndex(input, 0, input.Length - 1, 5);
            var high = FindLowHighIndex(input, mid, input.Length - 1, 5);
        }

        //1 2 5 5 5 5 5 7 9
        public static int FindLowHighIndex(int[] input, int low, int high,int key)
        {
            int index = -1;

            if (low > high && input[low ]==key)
                return low;

            if (low > high)
                return -1;

            var mid = (high + low) / 2;

            if (input[mid] <= key)
            {
                return  FindLowHighIndex(input, 0, mid-1, key);
            }
            else if (input[mid] > key)
            {
              return FindLowHighIndex(input, low, mid - 1, key);
            }

            return index;
        }
    }
}
