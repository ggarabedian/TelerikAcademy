namespace FindSetOfWords.PatriciaTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class PatriciaSuffixTrie<T>
    {
        private readonly int m_MinQueryLength;
        private readonly PatriciaTrie<T> m_InnerTrie;

        public PatriciaSuffixTrie(int minQueryLength)
            : this(minQueryLength, new PatriciaTrie<T>())
        {

        }

        internal PatriciaSuffixTrie(int minQueryLength, PatriciaTrie<T> innerTrie)
        {
            this.m_MinQueryLength = minQueryLength;
            this.m_InnerTrie = innerTrie;
        }

        protected int MinQueryLength
        {
            get { return this.m_MinQueryLength; }
        }

        public IEnumerable<T> Retrieve(string query)
        {
            return
                this.m_InnerTrie
                    .Retrieve(query)
                    .Distinct();
        }

        public void Add(string key, T value)
        {
            IEnumerable<StringPartition> allSuffixes = GetAllSuffixes(this.MinQueryLength, key);
            foreach (StringPartition currentSuffix in allSuffixes)
            {
                this.m_InnerTrie.Add(currentSuffix, value);
            }
        }

        private static IEnumerable<StringPartition> GetAllSuffixes(int minSuffixLength, string word)
        {
            for (int i = word.Length - minSuffixLength; i >= 0; i--)
            {
                yield return new StringPartition(word, i);
            }
        }
    }
}
