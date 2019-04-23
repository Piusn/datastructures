using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertHeapSort
    {
        public static void Sort(int[] arr)
        {
            var sortedArray = new int[arr.Length];

            var min = new AlgoExpertContinousMeanMinHeap(arr);

            int idx = 0;

            while (!min.IsEmpty)
            {
                sortedArray[idx] = min.Remove();
                idx++;
            }

        }
    }
}
