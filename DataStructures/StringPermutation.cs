using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class StringPermutation
    {
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
    }
}
