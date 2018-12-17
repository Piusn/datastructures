using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructures.Algorithms
{
    public class HeapSort
    {
        public static void Sort(int[] input)
        {
            List<int> output = new List<int>();

            Sort(input, 0, input.Length - 1, ref output);
        }

        //5,1,4,8,9,3,2   =n=7

        //0 1 2 3 4 5 6
        public static void Sort(int[] input, int start, int end, ref List<int> result)
        {
            //Start and n/2 = 3
            //left  = 2n+1
            //right = 2n+2
            var mid = (end - start) / 2;

            while (mid >= 0)
            {
                Heapify(mid, input, end);
                mid--;
            }


            var first = input[0];
            result.Add(first);

            if (end > start)
            {
                Swap(0, end, input);
                Sort(input, start, end - 1, ref result);
            }
        }

        public static void Heapify(int current, int[] input, int end)
        {
            var left = (2 * current) + 1;
            var right = (2 * current) + 2;

            //Has right child
            if (right <= end && input[right] < input[current] && left > end)
            {
                Swap(current, right, input);
            }

            //if has left child only
            if (left <= end && input[left] < input[current] && right > end)
            {
                Swap(current, left, input);
            }

            if (right <= end && left <= end)
            {
                if (input[current] > input[right] && input[right] < input[left])
                {
                    Swap(current, right, input);
                    return;
                }

                if (input[current] > input[left] && input[left] < input[right])
                {
                    Swap(current, left, input);
                    return;
                }
            }

        }

        public static void Swap(int left, int right, int[] input)
        {
            var temp = input[left];
            input[left] = input[right];
            input[right] = temp;
        }
    }
}
