using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertTrieNode
    {
        public Dictionary<char, AlgoExpertTrieNode> Nodes { get; set; }

        public AlgoExpertTrieNode()
        {
            Nodes = new Dictionary<char, AlgoExpertTrieNode>();
        }
    }

    public class AlgoExpertSuffixTree
    {
        public AlgoExpertTrieNode Root { get; set; }=new AlgoExpertTrieNode();

        public bool Contains(string search)
        {
            var current = Root;

            bool textFound = true;

            for (int i = 0; i < search.Length; i++)
            {
                if (current.Nodes.ContainsKey(search[i]))
                {
                    current = current.Nodes[search[i]];
                }
                else
                {
                    textFound = false;
                    break;
                }
            }

            return textFound;
        }

        public void From(string str)
        {
            var current = Root;

            for (int i = 0; i < str.Length; i++)
            {
                var ch = str[i];

                if (current.Nodes.ContainsKey(ch))
                {
                    current = current.Nodes[ch];
                }
                else
                {
                    var node = new AlgoExpertTrieNode();
                    current.Nodes.Add(ch, node);
                    current = node;
                }

                if (i == str.Length - 1)
                {
                    current.Nodes.Add('*', new AlgoExpertTrieNode());
                }
            }
        }
    }
}