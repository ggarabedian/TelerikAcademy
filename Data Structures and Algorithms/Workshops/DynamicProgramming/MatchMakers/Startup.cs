using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakers
{
    class Startup
    {
        static void Main()
        {
            var girls = new HashSet<string>();
            var boys = new HashSet<string>();
            var vertices = new Dictionary<string, List<string>>();

            var bestBoy = "";
            var bestGirl = "";
            var bestMatch = 0;
            //var currentInterestCount = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string gender = Console.ReadLine();
                int interestsCount = int.Parse(Console.ReadLine());
                var personInterests = Console.ReadLine().Split();

                foreach (var interest in personInterests)
                {
                    string from;
                    string to;

                    if (gender == "m")
                    {
                        from = name;
                        to = interest;
                        boys.Add(name);
                    }
                    else
                    {
                        from = interest;
                        to = name;
                        girls.Add(name);
                    }

                    if (!vertices.ContainsKey(from))
                    {
                        vertices[from] = new List<string>();
                    }

                    vertices[from].Add(to);
                }
            }

            var queue = new Queue<string>();
            var matches = new Dictionary<string, int>();

            foreach (var boy in boys)
            {
                queue.Clear();
                matches.Clear();

                queue.Enqueue(boy);

                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();

                    if (!vertices.ContainsKey(current))
                    {
                        continue;
                    }

                    foreach (var next in vertices[current])
                    {
                        if (girls.Contains(next))
                        {
                            if (!matches.ContainsKey(next))
                            {
                                matches[next] = 0;
                            }

                            matches[next]++;
                        }
                        else
                        {
                            queue.Enqueue(next);
                        }
                    }
                }

                foreach (var match in matches)
                {
                    if (bestMatch < match.Value)
                    {
                        bestMatch = match.Value;
                        bestGirl = match.Key;
                        bestBoy = boy;
                    }
                    else if (bestMatch == match.Value)
                    {
                        if (string.Compare(boy, bestBoy) >= 0)
                        {
                            bestMatch = match.Value;
                            bestGirl = match.Key;
                            bestBoy = boy;
                        }
                    }
                }
            }

            Console.WriteLine("{0} and {1} have {2} common interests!", bestBoy, bestGirl, bestMatch);
        }
    }
}
