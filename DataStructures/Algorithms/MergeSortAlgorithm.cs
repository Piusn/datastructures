using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms
{
    public class MergeSortAlgorithm
    {
        //6,4,5,1,9,7,3
        public static void MergeSort(int[] input)
        {

        }

        public static void Merge(int[] input, int[] temp, int low, int high, int mid)
        {
            int i = low;
            int j = high;
            int index = 0;

            while (i <= mid && j <= high)
            {
                if (input[i] < input[j])
                {
                    temp[index] = input[i];
                    i++;
                    index++;
                }
                else if (input[j] < input[i])
                {
                    temp[index] = input[j];
                    j++;
                    index++;
                }
            }

            while (i <= mid)
            {
                temp[index] = input[i];
                i++;
            }
            while (j <= high)
            {
                temp[index] = input[j];
                j++;
            }
        }

        public static void MergeSortHelper(int[] input, int low, int high)
        {
            if (low < high)
            {
                var mid = (low + high) / 2;

                MergeSortHelper(input, low, mid);
                MergeSortHelper(input, mid, high);

            }
        }
    }
}
