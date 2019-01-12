using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using DataStructures.CommonLibrary.Trees;

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
        public static string RemoveWhiteSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            int writeIndex = 0,
                readIndex = 0;

            char[] word = new char[input.Length];

            while (readIndex <= input.Length - 1)
            {
                if (!char.IsWhiteSpace(input[readIndex]))
                {
                    word[writeIndex] = input[readIndex];
                    writeIndex++;
                }
                readIndex++;
            }

            return new string(word);
        }

        public static void XmlToTree(string xmlString)
        {
            Stack<NAryTreeNode<string>> myStack = new Stack<NAryTreeNode<string>>();

            var reader = XmlReader.Create(new StringReader(xmlString));

            NAryTreeNode<string> currentNode = null;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(reader.Value);
                }



                if (reader.IsStartElement() || reader.NodeType == XmlNodeType.Text)
                {
                    if (currentNode == null)
                    {
                        currentNode = new NAryTreeNode<string>(reader.LocalName);
                        myStack.Push(currentNode);
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                        currentNode = currentNode.AddChild(reader.Value);
                    else
                    {
                        currentNode = currentNode.AddChild(reader.LocalName);
                        myStack.Push(currentNode);
                    }
                }

                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    currentNode = currentNode?.Parent;
                    myStack.Pop();
                }
            }
        }

        public static void FindAllParandrome(string input)
        {
            int count = 0;

            List<string> outputs = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int step = 1;

                if (i == 0)
                    continue;

                if (input[i - step] == input[i])
                {
                    outputs.Add(input.Substring(i - step, step + 1));
                }

                int left = i - step;
                int right = i + step;

                while (right < input.Length && input[left] == input[right] && left >= 0)
                {
                    outputs.Add(input.Substring(left, right - left + 1));
                    step += 1;

                    left = i - step;
                    right = i + step;
                }

                //if (input[left + 1] == input[right - 1] && left + 1 != i)
                //{
                //    outputs.Add(input.Substring(left + 1, right - 1 - left));
                //}

            }
        }

        public static void BooyeMooreHotspool(string text, string pattern)
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            int patternLength = pattern.Length;

            for (int i = 0; i < patternLength; i++)
            {
                var index = patternLength - i - 1;
                if (index <= 0)
                    index = patternLength;

                table[pattern[i]] = index;
            }
            //012345678
            //TRUSTHARDTOOTHBRUSHES
            //TOOTH
            int patternIndex = patternLength-1;
            int textIndex = patternLength-1;

            while (patternIndex >= 0)
            {
                if (pattern[patternIndex] == text[textIndex])
                {
                    textIndex--;
                    patternIndex--;
                    continue;
                }

                var skip = patternLength;

                if (table.ContainsKey(text[textIndex]))
                    skip = table[text[textIndex]];

                textIndex += skip;
                patternIndex = patternLength-1;
            }

            Console.WriteLine($"The index is {textIndex +1}");

        }
    }
}
