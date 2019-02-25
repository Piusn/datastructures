using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertSelectionSort
    {
        public static void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int smallestIndex = i;

                int movingIndex = i + 1;

                while (smallestIndex < input.Length && movingIndex < input.Length )
                {

                    if (input[movingIndex] < input[smallestIndex])
                    {
                        smallestIndex = movingIndex;
                    }
             
                    movingIndex++;
                }

                var temp = input[smallestIndex];
                input[smallestIndex] = input[i];
                input[i] = temp;
            }
        }
    }
}
