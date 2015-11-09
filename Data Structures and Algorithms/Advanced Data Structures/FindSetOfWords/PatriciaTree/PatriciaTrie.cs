namespace FindSetOfWords.PatriciaTree
{
    using System;
    using System.Collections.Generic;

    public class PatriciaTrie<T> : PatriciaTrieNode<T>
    {
        public PatriciaTrie()
            : base(
                new StringPartition(string.Empty),
                new Queue<T>(),
                new Dictionary<char, PatriciaTrieNode<T>>())
        {
        }

        public IEnumerable<T> Retrieve(string query)
        {
            return this.Retrieve(query, 0);
        }

        public virtual void Add(string key, T value)
        {
            if (key == null) throw new ArgumentNullException("key");
            this.Add(new StringPartition(key), value);
        }

        internal override void Add(StringPartition keyRest, T value)
        {
            this.GetOrCreateChild(keyRest, value);
        }
    }
}
