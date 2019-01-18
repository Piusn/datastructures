using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms
{
    public class QuickSort
    {
        //6,4,5,1,9,7,3
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                var pivot = SortHelper(arr, low, high);

                //Ensure you dont include pivot  - Had rough time here.
                //Its already in its sorted position you will get stackoverflow exception
                Sort(arr, low, pivot - 1);
                Sort(arr, pivot + 1, high);
            }
        }

        //123,6,44, 4, 5,150, 1,789, 9, 7, 3,6,89
        //123,6,44, 4, 5,89, 1,789, 9, 7, 3,6,150
        //                   j  i
        //0                                     12
        private int SortHelper(int[] input, int low, int high)
        {
            int pivot = input[low];

            int i = low;
            int j = high;

            //if high is greater than low
            while (i < j)
            {
                while (input[i] <= pivot && i < j)
                {
                    i++;
                }

                while (input[j] > pivot)
                {
                    j--;
                }

                if (input[i] > input[j])
                {
                    Console.WriteLine($"Swaping i={input[i]}      j={input[j]} for {string.Join(',', input)}");

                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }

            input[low] = input[j];
            input[j] = pivot;

            return j;
        }
    }
}
