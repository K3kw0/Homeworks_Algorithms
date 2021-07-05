using System;
using System.Collections.Generic;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n3 = new Node { Name = "n3" };
            var n1 = new Node { Left = n3, Name = "n1" };
            var n2 = new Node { Name = "n2" };
            var root = new Node { Left = n2, Right = n1, Name = "root" };

            Console.WriteLine("BFS: ");
            foreach (var n in BFS(root))
            {
                Console.WriteLine(n.Name);
            }

            Console.WriteLine("\nDFS: ");
            foreach (var n in DFS(root))
            {
                Console.WriteLine(n.Name);
            }
        }

        private static IEnumerable<Node> BFS(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var n = queue.Dequeue();
                yield return n;
                if (n.Left != null) queue.Enqueue(n.Left);
                if (n.Right != null) queue.Enqueue(n.Right);
            }
        }

        private static IEnumerable<Node> DFS(Node root)
        {
            var queue = new Stack<Node>();
            queue.Push(root);

            while (queue.Count > 0)
            {
                var n = queue.Pop();
                yield return n;
                if (n.Left != null) queue.Push(n.Left);
                if (n.Right != null) queue.Push(n.Right);
            }
        }
    }

    class Node
    {
        public string Name;
        public Node Left;
        public Node Right;
    }
}