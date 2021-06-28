using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{

    class ClsGraph
    {
        private int Vertices;

        private List<int>[] adj;

        public ClsGraph(int Vertices)
        {
            this.Vertices = Vertices;
            adj = new List<int>[Vertices];
            for (int i = 0; i < Vertices; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        void BFS(int s)
        {
            bool[] visited = new bool[Vertices];

            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.Write(" " + s);

                foreach (int next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[Vertices];

            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop();
                Console.Write(" " + s);
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

        public void PrintAdjacecnyMatrix()
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < Vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s += (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s += "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            ClsGraph graph = new ClsGraph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            graph.PrintAdjacecnyMatrix();

            Console.Write($"\nBFS с вершины 2 -->");
            graph.BFS(2);
            Console.Write($"\nDFS с вершины 2 -->");
            graph.DFS(2);
        }
    }
}