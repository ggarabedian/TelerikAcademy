namespace FindSetOfWords
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Trie;

    public class Startup
    {
        public static void Main()
        {
            ITrie<int> trie = new SuffixTrie<int>(3);

            BuildUp(@"../../books/The Adventures of Sherlock Holmes.txt", trie);

            LookUp("secret", trie);
            LookUp("case", trie);
            LookUp("murder", trie);

            Console.WriteLine();
        }

        private static void BuildUp(string fileName, ITrie<int> trie)
        {
            IEnumerable<WordAndRow> allWordsInFile = GetWordsFromFile(fileName);
            foreach (WordAndRow wordAndLine in allWordsInFile)
            {
                trie.Add(wordAndLine.Word, wordAndLine.Row);
            }
        }

        private static void LookUp(string searchString, ITrie<int> trie)
        {
            Console.WriteLine(new string('-', 119));
            Console.WriteLine("Looking for the word '{0}'", searchString);
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] result = trie.Retrieve(searchString).ToArray();
            stopWatch.Stop();

            string matchesText = String.Join(", ", result);
            int matchesCount = result.Count();

            if (matchesCount == 0)
            {
                Console.WriteLine("No matches found.\nTime: {0}", stopWatch.Elapsed);
            }
            else
            {
                Console.WriteLine(" {0} matches found. \n Time: {1}\n Lines: {2}",
                              matchesCount,
                              stopWatch.Elapsed,
                              matchesText);
            }
        }

        private static IEnumerable<WordAndRow> GetWordsFromFile(string file)
        {
            using (StreamReader reader = File.OpenText(file))
            {
                Console.WriteLine("Processing file {0} ...", file);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                int lineNo = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lineNo++;
                    IEnumerable<string> words = GetWordsFromLine(line);
                    foreach (string word in words)
                    {
                        yield return new WordAndRow { Row = lineNo, Word = word };
                    }
                }
                stopWatch.Stop();
                Console.WriteLine("Lines:{0}\tTime:{1}", lineNo, stopWatch.Elapsed);
            }
        }

        private static IEnumerable<string> GetWordsFromLine(string line)
        {
            var word = new StringBuilder();
            foreach (char ch in line)
            {
                if (char.IsLetter(ch))
                {
                    word.Append(ch);
                }
                else
                {
                    if (word.Length == 0) continue;
                    yield return word.ToString();
                    word.Clear();
                }
            }
        }

        private struct WordAndRow
        {
            public int Row;

            public string Word;
        }
    }
}
