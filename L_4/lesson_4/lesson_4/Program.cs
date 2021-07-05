using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lesson_4
{
                                   // задание 1

    //[RankColumn]
    //public class Test
    //{
    //    int num_let = 3, num_words = 15000;

    //    public void Arr_Search(string[] a)
    //    {
    //        if (a.Contains("TXP")) Console.WriteLine("Ok");
    //        else Console.WriteLine("Sad");
    //    }

    //    public void Hash_Search(HashSet<string> hashSet)
    //    {
    //        if (hashSet.Contains("TXP")) Console.WriteLine("Ok");
    //        else Console.WriteLine("Sad");
    //    }

    //    [Benchmark]
    //    public void Test_1_Hash()
    //    {
    //        HashSet<string> hashSet = new HashSet<string>();
    //        char[] let = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    //        Random q = new Random();
    //        for (int i = 0; i < num_words; i++)
    //        {
    //            string word = string.Empty;
    //            for (int e = 0; e < num_let; e++)
    //            {
    //                char let_num = (char)q.Next(0, let.Length - 1);
    //                word += let[let_num];
    //            }
    //            hashSet.Add(word);
    //        }
    //        Hash_Search(hashSet);
    //    }

    //    [Benchmark]
    //    public void Test_2_Arr()
    //    {
    //        char[] let = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    //        string[] a = new string[num_words];
    //        Random q = new Random();
    //        for (int i = 0; i < num_words; i++)
    //        {
    //            string word = string.Empty;
    //            for (int e = 0; e < num_let; e++)
    //            {
    //                char let_num = (char)q.Next(0, let.Length - 1);
    //                word += let[let_num];
    //            }
    //            a[i] = word;
    //        }
    //        Arr_Search(a);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<Test>();

            //                        // задание 2

            //var tree = new Tree<int>();
            //tree.Add(5);
            //tree.Add(3);
            //tree.Add(7);
            //tree.Add(1);
            //tree.Add(2);
            //tree.Add(8);
            //tree.Add(6);
            //tree.Add(9);

            //foreach (var item in tree.Pre())
            //{
            //    Console.Write(" " + item);
            //}

            //Console.WriteLine();

            //Console.Write("Введите число для удаления --> ");
            //int del = int.Parse(Console.ReadLine());
            //tree.Remove(del);

            //foreach (var item in tree.Pre())
            //{
            //    Console.Write(" " + item);
            //}

            //Console.Write("\nВведите число (поиск) --> ");
            //int n = int.Parse(Console.ReadLine());
            //if (tree.Contains(n)) Console.WriteLine("  Существует");
            //else Console.WriteLine("  Не существует");

        }
    }

    //class Node<T>
    //   where T : IComparable
    //{
    //    public T Data { get; set; }
    //    public Node<T> Left { get; set; }
    //    public Node<T> Right { get; set; }

    //    public Node(T data)
    //    {
    //        Data = data;
    //    }

    //    public void Add(T data)
    //    {
    //        var node = new Node<T>(data);
    //        if (node.Data.CompareTo(Data) == -1)
    //        {
    //            if (Left == null) Left = node;
    //            else Left.Add(data);
    //        }
    //        else
    //        {
    //            if (Right == null) Right = node;
    //            else Right.Add(data);
    //        }
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        if (obj is Node<T> item) return Data.CompareTo(item);
    //        else throw new Exception("Разные типы");
    //    }
    //}

    //class Tree<T>
    //    where T : IComparable
    //{
    //    public Node<T> Root { get; set; }
    //    public int Count { get; set; }

    //    public void Add(T data)
    //    {
    //        if (Root == null)
    //        {
    //            Root = new Node<T>(data);
    //            Count = 1;
    //            return;
    //        }

    //        Root.Add(data);
    //        Count++;
    //    }

    //    public void Remove(T data)
    //    {
    //        if (Root == null) return;

    //        Node<T> current = Root, parent = null;

    //        int result;
    //        do
    //        {
    //            result = data.CompareTo(current.Data);
    //            if (result < 0)
    //            {
    //                parent = current;
    //                current = current.Left;
    //            }
    //            else if (result > 0)
    //            {
    //                parent = current;
    //                current = current.Right;
    //            }
    //            if (current == null) return;
    //        }
    //        while (result != 0);

    //        if (current.Right == null)
    //        {
    //            if (current == Root) Root = current.Left;
    //            else
    //            {
    //                result = current.Data.CompareTo(parent.Data);
    //                if (result < 0) parent.Left = current.Left;
    //                else parent.Right = current.Left;
    //            }
    //        }
    //        else if (current.Right.Left == null)
    //        {
    //            current.Right.Left = current.Left;
    //            if (current == Root) Root = current.Right;
    //            else
    //            {
    //                result = current.Data.CompareTo(parent.Data);
    //                if (result < 0) parent.Left = current.Right;
    //                else parent.Right = current.Right;
    //            }
    //        }
    //        else
    //        {
    //            Node<T> min = current.Right.Left, prev = current.Right;
    //            while (min.Left != null)
    //            {
    //                prev = min;
    //                min = min.Left;
    //            }
    //            prev.Left = min.Right;
    //            min.Left = current.Left;
    //            min.Right = current.Right;

    //            if (current == Root) Root = min;
    //            else
    //            {
    //                result = current.Data.CompareTo(parent.Data);
    //                if (result < 0) parent.Left = min;
    //                else parent.Right = min;
    //            }
    //        }
    //        Count--;
    //    }

    //    public bool Contains(T data)
    //    {
    //        var current = Root;
    //        while (current != null)
    //        {
    //            var result = data.CompareTo(current.Data);
    //            if (result == 0) return true;
    //            if (result < 0) current = current.Left;
    //            else current = current.Right;
    //        }
    //        return false;
    //    }

    //    public List<T> Pre()
    //    {
    //        if (Root == null) return new List<T>();
    //        return Pre(Root);
    //    }

    //    private List<T> Pre(Node<T> node)
    //    {
    //        var list = new List<T>();
    //        if (node != null)
    //        {
    //            list.Add(node.Data);

    //            if (node.Left != null) list.AddRange(Pre(node.Left));
    //            if (node.Right != null) list.AddRange(Pre(node.Right));
    //        }
    //        return list;
    //    }
    //}
}