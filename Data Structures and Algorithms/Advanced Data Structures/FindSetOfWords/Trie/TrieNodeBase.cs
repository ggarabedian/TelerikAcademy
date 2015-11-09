namespace FindSetOfWords.Trie
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class TrieNodeBase<T>
    {
        protected abstract int KeyLength { get; }

        protected abstract IEnumerable<T> Values();

        protected abstract IEnumerable<TrieNodeBase<T>> Children();

        public void Add(string key, int position, T value)
        {
            if (key == null) throw new ArgumentNullException("key");
            if (EndOfString(position, key))
            {
                this.AddValue(value);
                return;
            }

            TrieNodeBase<T> child = this.GetOrCreateChild(key[position]);
            child.Add(key, position + 1, value);
        }

        protected abstract void AddValue(T value);

        protected abstract TrieNodeBase<T> GetOrCreateChild(char key);

        protected virtual IEnumerable<T> Retrieve(string query, int position)
        {
            return
                EndOfString(position, query)
                    ? this.ValuesDeep()
                    : this.SearchDeep(query, position);
        }

        protected virtual IEnumerable<T> SearchDeep(string query, int position)
        {
            TrieNodeBase<T> nextNode = this.GetChildOrNull(query, position);
            return nextNode != null
                       ? nextNode.Retrieve(query, position + nextNode.KeyLength)
                       : Enumerable.Empty<T>();
        }

        protected abstract TrieNodeBase<T> GetChildOrNull(string query, int position);

        private static bool EndOfString(int position, string text)
        {
            return position >= text.Length;
        }

        private IEnumerable<T> ValuesDeep()
        {
            return
                this.Subtree()
                    .SelectMany(node => node.Values());
        }

        protected IEnumerable<TrieNodeBase<T>> Subtree()
        {
            return
                Enumerable.Repeat(this, 1)
                    .Concat(this.Children().SelectMany(child => child.Subtree()));
        }
    }
}
