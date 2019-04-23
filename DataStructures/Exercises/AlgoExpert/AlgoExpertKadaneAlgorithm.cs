using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertKadaneAlgorithm
    {
        public AlgoExpertKadaneAlgorithm()
        {
            int[] arr = new[] { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };
            Find(arr);
        }
        public void Find(int[] arr)
        {
            int maximumToHere =0;
            int maxSofar =0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentValue = arr[i];
                maximumToHere += currentValue;

                if (maximumToHere <= 0)
                {
                    maximumToHere = currentValue >= 0 ? currentValue : 0;
                }

                if (maximumToHere > maxSofar)
                    maxSofar = maximumToHere;

            }
        }
    }
}
