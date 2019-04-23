using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMaxSumIncreasingSubsequence
    {
        public AlgoExpertMaxSumIncreasingSubsequence()
        {
            MaxSumIncreasingSubsequence(new[] { 10, 70, 20, 30, 50, 11, 30 });
        }

        public void MaxSumIncreasingSubsequence(int[] arr)
        {
            int[] sums = new int[arr.Length];
            int[] indexes = new int[arr.Length];
            sums[0] = arr[0];
            int maxIdex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                        continue;

                    sums[i] = Math.Max(sums[j] + arr[i], arr[i]);
                    indexes[i] = j;

                    if (sums[i] > sums[maxIdex])
                        maxIdex = i;
                }
            }
        }
    }
}