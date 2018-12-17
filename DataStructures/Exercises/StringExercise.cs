using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataStructures.Exercises
{
    public class StringExercise
    {
        #region Write a program to print all permutations of a given string

        public static void PermuteHelper(List<char> list, List<char> chosen)
        {
            //base
            if (!list.Any())
            {
                Console.WriteLine(String.Join(",", chosen));
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    //Choose
                    var current = list[i];
                    chosen.Add(current);
                    list.RemoveAt(i);

                    //Explore
                    PermuteHelper(list, chosen);

                    //Un-choose
                    chosen.Remove(current);
                    list.Insert(i, current);
                }
            }
        }

        public static void Permute(string str)
        {
            List<char> chosen = new List<char>();

            PermuteHelper(str.ToList(), chosen);
        }


        #endregion

        #region Find all N-digit numbers with equal sum of digits at even and odd index

        public static void FindEqualSumDigits(int number)
        {
            int oddSum = 0;
            int evenSum = 0;

            FindEqualSumDigitsHelper(number, ref oddSum, 0, 2);
            FindEqualSumDigitsHelper(number, ref evenSum, 1, 2);
        }

        public static void FindEqualSumDigitsHelper(int number, ref int sum, int index, int factor)
        {
            var str = number.ToString();

            if (index > number.ToString().Length - 1)
            {
                return;
            }
            else
            {
                sum = sum + (int)Char.GetNumericValue(str[index]);// Convert.ToInt32(str[index]);
                FindEqualSumDigitsHelper(number, ref sum, index + factor, factor);
            }
        }
        #endregion

        #region Reverse a string using stack data structure (STACK)

        public static void ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            str = "";

            var s2 = string.Join("", stack);

            while (stack.Count > 0)
            {
                str += stack.Pop();
            }
        }

        #endregion

        #region Remove duplicates from a string

        public static HashSet<string> UniqueWords(string input)
        {
            var arr = input.ToCharArray();
            input = new string(arr);

            var words = input.Split(" ");

            HashSet<string> uniqueWords = new HashSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                uniqueWords.Add(words[i]);
            }

            return uniqueWords;
        }

        public static void WordCount(string input)
        {
            SortedDictionary<string, int> wordCount = new SortedDictionary<string, int>();

            var words = input.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                wordCount[words[i]]++;
            }
        }


        #endregion

        //TODO: FindSubstringBruteForce/ KMP / Other string algorithm
        //abcadbdbt
        //dbt
        public static int FindSubstringBruteForce(string source, string pattern)
        {
            int patternIndex = 0;
            int sourceIndex = 0;

            for (int i = 0; i < source.Length; i++)
            {
                if (patternIndex == pattern.Length)
                {
                    return sourceIndex;
                }

                if (source[i] == pattern[patternIndex])
                {
                    if (sourceIndex == 0)
                        sourceIndex = i;

                    patternIndex++;
                    continue;
                    
                }

                if (source[i] != pattern[patternIndex] && patternIndex > 0)
                {
                    patternIndex = 0;
                    sourceIndex = 0;
                    if (source[i] == pattern[patternIndex])
                    {
                        if (sourceIndex == 0)
                            sourceIndex = i;

                        patternIndex++;
                    }
                }
            }

            for (int i = 0; i <= source.Length - pattern.Length; i++)
            {
                int j = 0;

                for (j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j] != source[j + i])
                    {
                        break;
                    }
                }

                if (j == pattern.Length)
                    return i;
            }

            return source.Length;
        }

        //TODO: https://www.youtube.com/watch?v=NnD96abizww Longest Common Subsequence
        //https://www.youtube.com/watch?v=sSno9rV8Rhg

        //TODO: https://www.youtube.com/watch?v=tABtJbLOQho
    }
}
