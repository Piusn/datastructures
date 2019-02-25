using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertQuickSort
    {
        public static void Run()
        {
            var input = new[] { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };
            Sort(input);
        }

        private static void Sort(int[] arr)
        {
            SortHelper(arr, 0, arr.Length - 1);
        }

        private static void SortHelper(int[] arr, int left, int right)
        {
            try
            {
                if (left <= right)
                {
                    var mid = Partition(arr, left, right);

                    SortHelper(arr, left, mid - 1);
                    SortHelper(arr, mid + 1, right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            var pivotIndex = left;
            var leftIndex = left + 1;
            var rightIndex = right;

            while (leftIndex <= rightIndex)
            {
                if (arr[leftIndex] > arr[pivotIndex] && arr[rightIndex] <= arr[pivotIndex])
                {
                    var temp = arr[leftIndex];
                    arr[leftIndex] = arr[rightIndex];
                    arr[rightIndex] = temp;
                }

                if (arr[leftIndex] <= arr[pivotIndex])
                    leftIndex++;

                if (arr[rightIndex] >= arr[pivotIndex])
                    rightIndex--;
            }

            var t = arr[pivotIndex];

            arr[pivotIndex] = arr[rightIndex];
            arr[rightIndex] = t;

            return rightIndex;
        }
    }
}