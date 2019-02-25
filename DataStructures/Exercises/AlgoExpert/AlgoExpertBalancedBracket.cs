using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertBalancedBracket
    {
        private static readonly Dictionary<char, char> character = new Dictionary<char, char>()
                                                            {
                                                                {'[', ']'},
                                                                {'(', ')'},
                                                                {'{', '}'}
                                                            };

        public static bool IsBalanced(string str)
        {
            Stack<char> stact = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (character.ContainsKey(str[i]))
                {
                    stact.Push(str[i]);
                }
                else
                {
                    if (stact.Count > 0)
                    {
                        var top = stact.Pop();

                        character.TryGetValue(top, out var persisted);

                        if (persisted == str[i])
                            continue;
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }

            return isBalanced;
        }
    }
}