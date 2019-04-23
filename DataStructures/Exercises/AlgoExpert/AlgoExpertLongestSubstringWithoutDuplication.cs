using System;
using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertLongestSubstringWithoutDuplication
    {
        public AlgoExpertLongestSubstringWithoutDuplication()
        {
            var str = LongestSubstringWithoutDuplication("clementisacap");
        }

        public string LongestSubstringWithoutDuplication(string str)
        {
            int startIndex = 0;
            string maxString = string.Empty;
            int start = 0;
            int end = 0;

            Dictionary<char, int> lastseen = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (lastseen.ContainsKey(str[i]))
                {
                    var lastSeenIndex = lastseen[str[i]];

                    startIndex = Math.Max(startIndex, lastSeenIndex + 1);
                  
                }

                if (i + 1 - startIndex > end - start)
                {
                    start = startIndex;
                    end = i;
                }
             
                lastseen[str[i]] = i;
            }

            return maxString;
        }
    }
}