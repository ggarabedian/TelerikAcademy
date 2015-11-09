namespace FindSetOfWords.Trie
{
    using System;
    using System.Collections.Generic;

    public class TrieNode<T> : TrieNodeBase<T>
    {
        private readonly Dictionary<char, TrieNode<T>> m_Children;
        private readonly Queue<T> m_Values;

        protected TrieNode()
        {
            this.m_Children = new Dictionary<char, TrieNode<T>>();
            this.m_Values = new Queue<T>();
        }

        protected override int KeyLength
        {
            get { return 1; }
        }

        protected override IEnumerable<TrieNodeBase<T>> Children()
        {
            return this.m_Children.Values;
        }

        protected override IEnumerable<T> Values()
        {
            return this.m_Values;
        }

        protected override TrieNodeBase<T> GetOrCreateChild(char key)
        {
            TrieNode<T> result;
            if (!this.m_Children.TryGetValue(key, out result))
            {
                result = new TrieNode<T>();
                this.m_Children.Add(key, result);
            }
            return result;
        }

        protected override TrieNodeBase<T> GetChildOrNull(string query, int position)
        {
            if (query == null) throw new ArgumentNullException("query");
            TrieNode<T> childNode;
            return
                this.m_Children.TryGetValue(query[position], out childNode)
                    ? childNode
                    : null;
        }

        protected override void AddValue(T value)
        {
            this.m_Values.Enqueue(value);
        }
    }
}
