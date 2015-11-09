namespace FindSetOfWords.Trie
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class ConcurrentTrieNode<T> : TrieNodeBase<T>
    {
        private readonly ConcurrentDictionary<char, ConcurrentTrieNode<T>> m_Children;
        private readonly ConcurrentQueue<T> m_Values;

        public ConcurrentTrieNode()
        {
            this.m_Children = new ConcurrentDictionary<char, ConcurrentTrieNode<T>>();
            this.m_Values = new ConcurrentQueue<T>();
        }


        protected override int KeyLength
        {
            get { return 1; }
        }

        protected override IEnumerable<T> Values()
        {
            return this.m_Values;
        }

        protected override IEnumerable<TrieNodeBase<T>> Children()
        {
            return this.m_Children.Values;
        }

        protected override void AddValue(T value)
        {
            this.m_Values.Enqueue(value);
        }

        protected override TrieNodeBase<T> GetOrCreateChild(char key)
        {
            return this.m_Children.GetOrAdd(key, new ConcurrentTrieNode<T>());
        }

        protected override TrieNodeBase<T> GetChildOrNull(string query, int position)
        {
            if (query == null) throw new ArgumentNullException("query");
            ConcurrentTrieNode<T> childNode;
            return
                this.m_Children.TryGetValue(query[position], out childNode)
                    ? childNode
                    : null;
        }
    }
}
