using System;
using System.Collections.Generic;
using System.Linq;

namespace Distances.Solution.CSharp
{
    public class DistancesSolution
    {
        class Edge : IComparable<Edge>
        {
            public int Vertex { get; set; }

            public int Weight { get; set; }

            public Edge(int vertex, int weight)
            {
                this.Vertex = vertex;
                this.Weight = weight;
            }

            public override string ToString()
            {
                return string.Format("Vertex: {0}, Weight: {1}", Vertex, Weight);
            }

            public int CompareTo(Edge other)
            {
                int weightCompare = this.Weight.CompareTo(other.Weight);
                if (weightCompare == 0)
                {
                    return this.Vertex.CompareTo(other.Vertex);
                }
                return weightCompare;
            }
        }

        private static int m;
        private static int n;
        private static int start;
        private static int end;
        private static int middle1;
        private static int middle2;
        private static List<Edge>[] vertices;

        public static void Main()
        {
            Console.WriteLine(Run());
        }

        public static string Run()
        {
            ReadInput();
            return Solve();
        }

        private static string Solve()
        {
            int[] distances1 = FindPath(middle1, new int[] { start, end, middle2 });
            int[] distances2 = FindPath(middle2, new int[] { start, end, middle1 });

            int startToMiddle1 = distances1[start];
            int startToMiddle2 = distances2[start];

            int middle1ToMiddle2 = distances1[middle2];
            int middle2ToMiddle1 = distances2[middle1];

            int middle1ToEnd = distances1[end];
            int middle2ToEnd = distances2[end];

            if ((middle1ToMiddle2 == int.MaxValue || middle2ToMiddle1 == int.MaxValue) ||
                (startToMiddle1 == int.MaxValue && startToMiddle2 == int.MaxValue) ||
                (middle1ToEnd == int.MaxValue && middle2ToEnd == int.MaxValue))
            {
                return "No path!";
            }
            else
            {
                var startToMiddle1ToMiddle2ToEnd = startToMiddle1 + middle1ToMiddle2 + middle2ToEnd;
                var startToMiddle2ToMiddle1ToEnd = startToMiddle2 + middle2ToMiddle1 + middle1ToEnd;

                var path = Math.Min(startToMiddle1ToMiddle2ToEnd, startToMiddle2ToMiddle1ToEnd);
                return path.ToString();
            }
        }

        private static int[] FindPath(int from, int[] without)
        {
            HashSet<int> used = new HashSet<int>();
            int[] distances = new int[vertices.Length].Select(d => int.MaxValue).ToArray();

            SortedSet<Edge> queue = new SortedSet<Edge>();
            distances[from] = 0;

            queue.Add(new Edge(from, 0));

            foreach (var withoutVertex in without)
            {
                used.Add(withoutVertex);
            }

            while (queue.Count > 0)
            {
                var current = queue.First();
                queue.Remove(current);
                used.Add(current.Vertex);

                foreach (var edge in vertices[current.Vertex])
                {
                    var oldDistances = distances[edge.Vertex];
                    var newDistance = distances[current.Vertex] + edge.Weight;
                    if (newDistance < oldDistances)
                    {
                        distances[edge.Vertex] = newDistance;
                        queue.Add(new Edge(edge.Vertex, newDistance));
                    }
                }
                while (queue.Count > 0 && used.Contains(queue.First().Vertex))
                {
                    queue.Remove(queue.First());
                }
            }

            return distances;
        }

        private static void ReadInput()
        {
            int[] mn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = mn[0];
            m = mn[1];

            int[] se = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            start = se[0] - 1;
            end = se[1] - 1;

            int[] m12 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            middle1 = m12[0] - 1;
            middle2 = m12[1] - 1;

            vertices = new List<Edge>[n];

            for (int i = 0; i < m; i++)
            {
                var fromToWeight = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                AddEdge(fromToWeight[0] - 1, fromToWeight[1] - 1, fromToWeight[2]);
                AddEdge(fromToWeight[1] - 1, fromToWeight[0] - 1, fromToWeight[2]);
            }
        }

        private static void AddEdge(int from, int to, int weight)
        {
            if (vertices[from] == null)
            {
                vertices[from] = new List<Edge>();
            }
            vertices[from].Add(new Edge(to, weight));
        }
    }
}