using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Exercises
{
    public static class RemoveDuplicateFromString
    {
        public static string RemoveDuplicates(string input)
        {
            HashSet<char> temp = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {
                temp.Add(input[i]);
            }

            return new string(temp.ToArray());
        }
    }
}