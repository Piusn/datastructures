using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertLongestParandromicSubstring
    {
        public AlgoExpertLongestParandromicSubstring()
        {
            var sub = LongestParandromicSubstring("abaxyzzyxf");
        }
        public string LongestParandromicSubstring(string str)
        {
            string maxParandrome = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    var sub = str.Substring(i, j - i);

                    if (IsParandrome(sub))
                    {
                        maxParandrome = maxParandrome.Length > sub.Length ? maxParandrome : sub;
                    }
                }
            }

            return maxParandrome;
        }

        public bool IsParandrome(string str)
        {
            int start = 0;
            int end = str.Length - 1;

            bool isParandrome = false;

            while (start <= end)
            {
                var left = str[start];
                var right = str[end];

                if (left == right)
                {
                    isParandrome = true;
                    start++;
                    end--;
                }
                else
                {
                    isParandrome = false;

                    break;
                }
               
            }

           // isParandrome = start == end;
            return isParandrome;
        }
    }
}
