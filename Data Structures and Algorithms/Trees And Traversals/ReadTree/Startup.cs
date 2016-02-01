namespace ReadTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /*
    You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), 
    each in the range (0..N-1).
    Write a program to read the tree and find:
    01. The root node
    02. All leaf nodes
    03. All middle nodes
    04. The longest path in the tree
    05. (*) All paths in the tree with given sum `S` of their nodes
    06. (*) All subtrees with given sum `S` of their nodes
    */
    public class Startup
    {
        public static void Main()
        {
            string input = @"
7
2 4
3 2
5 0
3 5
5 6
5 1";

            Console.SetIn(new StringReader(input.Trim()));
            int n = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                var parentChildPair = Console.ReadLine().Split(' ');
                int parent = int.Parse(parentChildPair[0]);
                int child = int.Parse(parentChildPair[1]);

                nodes[parent].Children.Add(nodes[child]);

                nodes[parent].Value = parent;
                nodes[child].Value = child;
                nodes[child].Parent = nodes[parent];
            }

            var root = FindRootNode(nodes);

            Console.WriteLine("The root node has a value of {0}.", root.Value);
            Console.WriteLine("The leaf nodes have values as follows: {0}", string.Join(", ", FindLeafNodes(nodes)));  
            Console.WriteLine("The middle nodes have values as follows: {0}", string.Join(", ", FindMiddleNodes(nodes)));
            Console.WriteLine("The longest path is: {0}", FindLongestPath(root));
        }

        //// 01. The root node
        private static TreeNode<int> FindRootNode(TreeNode<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Parent == null)
                {
                    return node;
                }
            }

            throw new ArgumentException("No root found!");
        }

        //// 02. All leaf nodes
        private static List<int> FindLeafNodes(TreeNode<int>[] nodes)
        {
            var leafValues = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafValues.Add(node.Value);
                }
            }

            return leafValues;
        }

        //// 03. All middle nodes
        private static List<int> FindMiddleNodes(TreeNode<int>[] nodes)
        {
            var leafValues = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count > 0 && node.Parent != null)
                {
                    leafValues.Add(node.Value);
                }
            }

            return leafValues;
        }

        //// 04. The longest path in the tree
        private static int FindLongestPath(TreeNode<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPathLength = 0;
            foreach (var node in root.Children)
            {
                maxPathLength = Math.Max(maxPathLength, FindLongestPath(node));
            }

            return maxPathLength + 1;
        }
    }
}
