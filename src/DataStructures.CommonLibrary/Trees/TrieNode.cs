using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CommonLibrary.Trees
{
    public class TrieNode
    {
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, TrieNode> Words { get; set; }

        public TrieNode()
        {
            Words = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }

        public void InsertWord(string word)
        {
            var characters = word.ToCharArray();

            var current = this;

            for (int i = 0; i < characters.Length; i++)
            {
                if (!Words.ContainsKey(characters[i]))
                {
                    var trie = new TrieNode() { };
                    current.Words.Add(characters[i], trie);
                    current = trie;
                    continue;
                }
                current = current.Words[characters[i]];
            }

            current.IsEndOfWord = true;
        }
    }
}
