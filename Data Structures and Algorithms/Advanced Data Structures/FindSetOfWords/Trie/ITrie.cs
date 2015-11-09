namespace FindSetOfWords.Trie
{
    using System.Collections.Generic;

    public interface ITrie<T>
    {
        IEnumerable<T> Retrieve(string query);

        void Add(string key, T value);
    }
}
