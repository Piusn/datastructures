using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class NumberExercise
    {
        //TODO: Coin change brute force
        //https://www.youtube.com/watch?v=fF_RBbvQbi4
        /// <summary>
        /// [100,50,20,10]
        /// </summary>
        /// <param name="denominations"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int CoinChange(int[] denominations, int value)
        {
            //Assume they are sorted descending
            int index = 0;
            int remainder = value;
            int counter = 0;
            while (true)
            {
                if (remainder == 0)
                    break;

                var currentValue = denominations[index];

                if (currentValue <= remainder)
                {
                    remainder = remainder - currentValue;
                    counter++;
                }
                else
                {
                    index++;
                }
            }

            return counter;
        }

        //TODO: Romans to numbers

        public static int ConvertRomanToInteger(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            Dictionary<char, int> romanInteger = new Dictionary<char, int>()
                                                   {
                                                       {'I',1 },
                                                       {'V',5 },
                                                       {'X',10 },
                                                       {'L',50 },
                                                       {'C',100 },
                                                       {'D',500 },
                                                       {'M',1000 }
                                                   };

            var characters = s.ToCharArray();

            int index = 0;
            int total = 0;

            while (index < characters.Length)
            {
                var character = characters[index];

                Char nextCharacter = 'f';

                if (index + 1 < characters.Length)
                    nextCharacter = characters[index + 1];

                if (character == 'M' || character == 'D' ||
                    character == 'V' || character == 'L' ||
                    (character == 'I' && nextCharacter != 'X' && nextCharacter != 'V')
                    || (character == 'C' && nextCharacter != 'D' && nextCharacter != 'M')
                    || (character == 'X' && nextCharacter != 'L' && nextCharacter != 'C'))
                {
                    total += romanInteger[character];
                    index++;
                    continue;
                }

                if (character == 'I' && nextCharacter == 'I')
                {
                    total += romanInteger[character]; ;
                    index++;
                }


                //IX, IV, XL,XC, CD, CM
                if (character == 'I' && nextCharacter == 'X')
                {
                    total += romanInteger['X'] - romanInteger['I'];
                    index += 2;
                }
                if (character == 'I' && nextCharacter == 'V')
                {
                    total += romanInteger['V'] - romanInteger['I'];
                    index += 2;
                }


                if (character == 'X' && nextCharacter == 'L')
                {
                    total += romanInteger['L'] - romanInteger['X'];
                    index += 2;
                }
                if (character == 'X' && nextCharacter == 'C')
                {
                    total += romanInteger['C'] - romanInteger['X'];
                    index += 2;
                }


                if (character == 'C' && nextCharacter == 'D')
                {
                    total += romanInteger['D'] - romanInteger['C'];
                    index += 2;
                }
                if (character == 'C' && nextCharacter == 'M')
                {
                    total += romanInteger['M'] - romanInteger['C'];
                    index += 2;
                }

            }

            return total;
        }

        //TODO: Median of two sorted arrays
        public static double FindMeanOfTwoSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMeanOfTwoSortedArrays(nums2, nums1);

            //binary sort the two arrays and ensure we have equal amount of items on left and right
            int leftStart = 0;
            int leftEnd = nums1.Length;

            var median = FindMeanOfTwoSortedArraysHelper(nums1, nums2, leftStart, leftEnd);

            return median;
        }

        public static double FindMeanOfTwoSortedArraysHelper(int[] left, int[] right, int leftStart, int leftEnd)
        {
            int partitionLeft = (leftStart + leftEnd) / 2;

            int leftMin = partitionLeft == 0 ? int.MinValue : left[partitionLeft - 1];
            int leftMax = partitionLeft == left.Length ? int.MaxValue : left[partitionLeft];

            int partitionRight = ((left.Length + right.Length + 1) / 2) - partitionLeft;

            int rightMin = partitionRight == 0 ? int.MinValue : right[partitionRight - 1];
            int rightMax = partitionRight == right.Length ? int.MaxValue : right[partitionRight];

            if (leftMin <= rightMax && rightMin <= leftMax)
            {
                if ((left.Length + right.Length) % 2 == 0)
                {
                    return (Math.Max(leftMin, rightMin) + (Math.Min(rightMax, leftMax))) / 2.0;
                }
                else
                {
                    return Math.Max(leftMin, rightMin);
                }
            }
            else if (leftMax > rightMin)
            {
                leftEnd = partitionLeft - 1;
            }
            else
            {
                leftStart = partitionLeft + 1;
            }

            return FindMeanOfTwoSortedArraysHelper(left, right, leftStart, leftEnd);

        }

        //TODO: Knapsack
    }
}
