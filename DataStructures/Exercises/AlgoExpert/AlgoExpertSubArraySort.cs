using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertSubArraySort
    {
        public static void Sort(int[] arr)
        {
            int minOutOfOrder = int.MaxValue;
            int maxOutOfOrder = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        minOutOfOrder = Math.Min(minOutOfOrder, arr[i]);
                        maxOutOfOrder = Math.Max(maxOutOfOrder, arr[i]);
                      
                    }
                    continue;
                }
                if (i == arr.Length - 1)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        minOutOfOrder = Math.Min(minOutOfOrder, arr[i]);
                        maxOutOfOrder = Math.Max(maxOutOfOrder, arr[i]);
                      
                    }
                    continue;
                }

                if (arr[i] < arr[i - 1] || arr[i] > arr[i + 1])
                {
                    minOutOfOrder = Math.Min(minOutOfOrder, arr[i]);
                    maxOutOfOrder = Math.Max(maxOutOfOrder, arr[i]);

                    continue;
                }
            }

            int minOutOfOrderIndex = 0;
            int maxOutOfOrderIndex = arr.Length - 1;

            while (minOutOfOrder >= arr[minOutOfOrderIndex])
            {
                minOutOfOrderIndex++;
            }

            while (maxOutOfOrder <= arr[maxOutOfOrderIndex])
            {
                maxOutOfOrderIndex--;
            }
        }
    }
}