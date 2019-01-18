using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int j = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                j = i;
                while (j >= 1 && arr[j] < arr[j - 1])
                {
                    var temp = arr[j];

                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;

                    j--;
                }
            }
        }
    }
}
