namespace FindSetOfWords.Trie
{
    using System.Collections.Generic;

    public class Trie<T> : TrieNode<T>
    {
        public IEnumerable<T> Retrieve(string query)
        {
            return this.Retrieve(query, 0);
        }

        public void Add(string key, T value)
        {
            this.Add(key, 0, value);
        }
    }
}
