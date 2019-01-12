using System;
using System.Collections.Generic;
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
                Console.WriteLine(string.Join(",", chosen));
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
                sum = sum + (int)char.GetNumericValue(str[index]);// Convert.ToInt32(str[index]);
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

        #region Find substring brute force
        public static int FindSubstringBruteForce(string source, string pattern)
        {
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

        #endregion

        #region Find substring Rabin-karp algorithm

        private static int ComputeHash(char[] character)
        {
            int hash = 0;

            for (int i = 0; i < character.Length; i++)
            {
                hash += character[i] * 101 ^ i;
            }
            return hash;
        }
        public static int FindSubstringRabinKarp(string text, string pattern)
        {
            int hash = ComputeHash(pattern.ToCharArray());

            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char[] characters = new char[pattern.Length];

                for (int j = 0; j < pattern.Length; j++)
                {
                    characters[j] = text[j + i];
                }

                var stringHash = ComputeHash(characters);

                if (hash == stringHash)
                {
                    startIndex = i;
                    endIndex = i + pattern.Length - 1;
                }
            }

            return startIndex;
        }

        #endregion

        #region Find substring KMP algorithm

        #endregion

        #region Find substring Boyer - Mooore algorithm

        #endregion

        #region Longest Common Subsequence
        //TODO: https://www.youtube.com/watch?v=NnD96abizww Longest Common Subsequence
        //https://www.youtube.com/watch?v=sSno9rV8Rhg
        //TODO: https://www.youtube.com/watch?v=tABtJbLOQho

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left">abcdaf</param>
        /// <param name="right">acbcf</param>
        /// <returns></returns>
        public static string LongestCommonSubsequence(string left, string right)
        {
            int[,] matrix = new int[left.Length, right.Length];
            List<char> c = new List<char>();
            for (int i = 0; i < left.Length; i++)
            {
                for (int j = 0; j < right.Length; j++)
                {
                    if (left[i] == right[j])
                    {
                        matrix[i, j] = 1;
                        c.Add(left[i]);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 1];
                    }
                }
            }

            return new string(c.ToArray());
            #endregion
        }
    }
}
