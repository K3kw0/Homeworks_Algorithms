using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_8
{
    class Program
    {
        static void BucketSort(int[] a)
        {
            int min = a.Min();
            int max = a.Max();

            List<int>[] bucket = new List<int>[max - min + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < a.Length; i++)
            {
                bucket[a[i] - min].Add(a[i]);
            }

            int n = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        a[n] = bucket[i][j];
                        n++;
                    }
                }
            }
            Console.WriteLine();
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
        }

        public static void Main()
        {
            Console.Write("Исходный массив -->");
            int[] a = { 466, 99, 10031, 4, 32, 1, 0 };
            Print(a);
            BucketSort(a);
            Console.Write("Отсортированный массив -->");
            Print(a);
        }
    }
}
