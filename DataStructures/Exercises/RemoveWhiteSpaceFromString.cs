using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Exercises
{
    public static class RemoveWhiteSpaceFromString
    {
        public static string RemoveWhiteSpaces(string input)
        {
            int read = 0;
            int write = 0;

            char[] temp = new char[input.Length];

            while (read < input.Length)
            {
                if (input[read] == ' ' || input[read] == '\t')
                {
                    read++;
                }
                else
                {
                    temp[write] = input[read];
                    write++;
                    read++;
                }
            }

            return new string(temp.Take(write).ToArray());
        }
    }
}
