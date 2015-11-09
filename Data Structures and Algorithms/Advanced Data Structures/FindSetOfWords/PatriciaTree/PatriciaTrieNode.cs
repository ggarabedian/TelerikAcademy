namespace FindSetOfWords.PatriciaTree
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    using Trie;

    [DebuggerDisplay("'{m_Key}'")]
    public class PatriciaTrieNode<T> : TrieNodeBase<T>
    {
        private Dictionary<char, PatriciaTrieNode<T>> m_Children;
        private StringPartition m_Key;
        private Queue<T> m_Values;

        protected PatriciaTrieNode(StringPartition key, T value)
            : this(key, new Queue<T>(new[] { value }), new Dictionary<char, PatriciaTrieNode<T>>())
        {
        }

        protected PatriciaTrieNode(StringPartition key, Queue<T> values,
            Dictionary<char, PatriciaTrieNode<T>> children)
        {
            this.m_Values = values;
            this.m_Key = key;
            this.m_Children = children;
        }

        protected override int KeyLength
        {
            get { return this.m_Key.Length; }
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

        internal virtual void Add(StringPartition keyRest, T value)
        {
            ZipResult zipResult = this.m_Key.ZipWith(keyRest);

            switch (zipResult.MatchKind)
            {
                case MatchKind.ExactMatch:
                    this.AddValue(value);
                    break;

                case MatchKind.IsContained:
                    this.GetOrCreateChild(zipResult.OtherRest, value);
                    break;

                case MatchKind.Contains:
                    this.SplitOne(zipResult, value);
                    break;

                case MatchKind.Partial:
                    this.SplitTwo(zipResult, value);
                    break;
            }
        }


        private void SplitOne(ZipResult zipResult, T value)
        {
            var leftChild = new PatriciaTrieNode<T>(zipResult.ThisRest, this.m_Values, this.m_Children);

            this.m_Children = new Dictionary<char, PatriciaTrieNode<T>>();
            this.m_Values = new Queue<T>();
            this.AddValue(value);
            this.m_Key = zipResult.CommonHead;

            this.m_Children.Add(zipResult.ThisRest[0], leftChild);
        }

        private void SplitTwo(ZipResult zipResult, T value)
        {
            var leftChild = new PatriciaTrieNode<T>(zipResult.ThisRest, this.m_Values, this.m_Children);
            var rightChild = new PatriciaTrieNode<T>(zipResult.OtherRest, value);

            this.m_Children = new Dictionary<char, PatriciaTrieNode<T>>();
            this.m_Values = new Queue<T>();
            this.m_Key = zipResult.CommonHead;

            char leftKey = zipResult.ThisRest[0];
            this.m_Children.Add(leftKey, leftChild);
            char rightKey = zipResult.OtherRest[0];
            this.m_Children.Add(rightKey, rightChild);
        }

        protected void GetOrCreateChild(StringPartition key, T value)
        {
            PatriciaTrieNode<T> child;
            if (!this.m_Children.TryGetValue(key[0], out child))
            {
                child = new PatriciaTrieNode<T>(key, value);
                this.m_Children.Add(key[0], child);
            }
            else
            {
                child.Add(key, value);
            }
        }

        protected override TrieNodeBase<T> GetOrCreateChild(char key)
        {
            throw new NotSupportedException("Use alternative signature instead.");
        }

        protected override TrieNodeBase<T> GetChildOrNull(string query, int position)
        {
            if (query == null) throw new ArgumentNullException("query");
            PatriciaTrieNode<T> child;
            if (this.m_Children.TryGetValue(query[position], out child))
            {
                var queryPartition = new StringPartition(query, position, child.m_Key.Length);
                if (child.m_Key.StartsWith(queryPartition))
                {
                    return child;
                }
            }
            return null;
        }

        public string Traversal()
        {
            var result = new StringBuilder();
            result.Append(this.m_Key);

            string subtreeResult = string.Join(" ; ", this.m_Children.Values.Select(node => node.Traversal()).ToArray());
            if (subtreeResult.Length != 0)
            {
                result.Append("[");
                result.Append(subtreeResult);
                result.Append("]");
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return
                string.Format(
                    "Key: {0}, Values: {1} Children:{2}, ",
                    this.m_Key,
                    this.Values().Count(),
                    String.Join(";", this.m_Children.Keys));
        }
    }
}
