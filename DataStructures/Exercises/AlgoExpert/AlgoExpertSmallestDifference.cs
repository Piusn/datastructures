using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertSmallestDifference
    {
        public static int[] FindSmallestDifference(int[] arr1, int[] arr2)
        {
            int[] resultArray = new int[2];
            int difference = Int32.MaxValue;
            int currentDifference = Int32.MaxValue;

            //pointers
            int arr1Pointer = 0;
            int arr2Pointer = 0;

            while (arr1Pointer < arr1.Length && arr2Pointer < arr2.Length)
            {
                var firstNum = arr1[arr1Pointer];
                var secondNum = arr2[arr2Pointer];

                if (firstNum < secondNum)
                {
                    currentDifference = secondNum - firstNum;
                    arr1Pointer++;
                }

                if (secondNum < firstNum)
                {
                    currentDifference = firstNum - secondNum;
                    arr2Pointer++;
                }

                if (secondNum == firstNum)
                {
                    resultArray[0] = firstNum;
                    resultArray[1] = secondNum;
                    difference = 0;

                    break;
                }

                if (currentDifference < difference)
                {
                    difference = currentDifference;

                    resultArray[0] = firstNum;
                    resultArray[1] = secondNum;
                }
            }
            return resultArray;
        }
    }
}