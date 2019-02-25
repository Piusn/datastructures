using System;

namespace DataStructures.Exercises
{
    public static class LongestCommonSubstring
    {
        public static int Brute(string str1, string str2)
        {
            int length = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        int currentCounter = 1;
                        int str1Counter = i + 1;
                        int str2Counter = j + 1;

                        while (str1Counter < str1.Length &&
                               str2Counter < str2.Length && 
                               str1[str1Counter] == str2[str2Counter])
                        {
                            currentCounter++;
                            str1Counter++;
                            str2Counter++;
                        }

                        if (currentCounter > length)
                            length = currentCounter;
                    }
                }
            }

            return length;
        }

        public static int DpBottomUp(string first, string second)
        {
            int [,] matrix=new int[first.Length,second.Length];

            int maxLength = 0;

            for (int i = 1; i < first.Length; i++)
            {
                for (int j = 1; j < second.Length; j++)
                {
                    if (first[i-1] == second[j-1])
                    {
                        matrix[i, j] = 1 + matrix[i - 1, j - 1];
                        maxLength = Math.Max(maxLength, matrix[i, j]);
                    }
                }
            }

            return maxLength;
        }
    }
}