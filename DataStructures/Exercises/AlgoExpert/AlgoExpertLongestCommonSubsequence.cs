using System;

namespace DataStructures.Exercises
{
    public static class AlgoExpertLongestCommonSubsequence
    {
        public static int FindLCS(string str1, string str2)
        {
            var count = FindLCSHelper(0, 0, str1, str2);

            return count;
        }

        private static int FindLCSHelper(int i, int j, string str1, string str2)
        {
            if (i == str1.Length || j == str2.Length)
                return 0;

            if (str1[i] == str2[j])
                return 1 + FindLCSHelper(i + 1, j + 1, str1, str2);

            return Math.Max(FindLCSHelper(i + 1, j, str1, str2), FindLCSHelper(i, j + 1, str1, str2));
        }
    }
}