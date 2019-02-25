using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Exercises
{
    public class NumberSum
    {
        public static int[] SumWithHashtable(int[] input, int target)
        {
            int[] result = new int[2];

            Hashtable hash = new Hashtable();

            for (int i = 0; i < input.Length; i++)
            {
                int remainder = target - input[i];

                if (hash.ContainsKey(remainder))
                {
                    var savedRemainder = (bool)hash[remainder];

                    if (savedRemainder)
                    {
                        result[0] = input[i];
                        result[1] = remainder;
                        break;
                    }
                }

                hash.Add(input[i], true);
            }

            return result;
        }

        public static int[] SumWithoutHashtable(int[] input, int target)
        {
            int[] result = new int[2];

            Array.Sort(input);

            int left = 0,
                right = input.Length - 1;

            while (left <= right)
            {
                var leftValue = input[left];
                var rightValue = input[right];

                if (leftValue + rightValue == target)
                {
                    result[0] = leftValue;
                    result[1] = rightValue;

                    break;
                }
                if (leftValue + rightValue < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }

        public static List<List<int>> ThreeSum(int[] input, int target)
        {
            List<List<int>> result = new List<List<int>>();

            Array.Sort(input);

            for (int i = 0; i < input.Length; i++)
            {
                List<int> temp = new List<int>();

                var currentNum = input[i];

                int left = i + 1;

                int right = input.Length - 1;

                while (left < right)
                {
                    var currentSum = input[left] + input[right] + currentNum;

                    if (currentSum == target)
                    {
                        temp.Add(currentNum);
                        temp.Add(input[left]);
                        temp.Add(input[right]);

                        result.Add(temp);

                        temp = new List<int>();
                    }

                    if (currentSum <= target)
                    {
                        left++;
                    }

                    if (currentSum > target)
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}