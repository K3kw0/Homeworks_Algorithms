using System;

namespace lesson_7
{
    class Program
    {
        static void Show(int[,] a)
        {
            for (int m = 0; m < a.GetLength(0); m++)
            {
                for (int n = 0; n < a.GetLength(1); n++)
                {
                    Console.Write(" " + a[m, n]);
                }
                Console.WriteLine();
            }
        }

        static void Show_Map(int[][] Map)
        {
            for (int i = 0; i < Map.Length; i++)
            {
                for (int j = 0; j < Map[i].Length; j++)
                {
                    Console.Write(" " + Map[i][j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            // Задача на кол-во маршрутов на прямоугольном поле

            Console.WriteLine("Кол-во маршрутов на прямоугольном поле:");
            int[,] a = new int[3, 5];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                a[0, i] = 1;
            }
            for (int j = 1; j < a.GetLength(0); j++)
            {
                a[j, 0] = 1;
                for (int i = 1; i < a.GetLength(1); i++)
                {
                    a[j, i] = a[j, i - 1] + a[j - 1, i];
                }
            }
            Show(a);


            // Задача на кол-во маршрутов с препядствиями

            Console.WriteLine("\nКарта препядствий:");
            int[][] Map = new int[3][];
            Map[0] = new int[5];
            Map[1] = new int[5];
            Map[2] = new int[5];
            Random qwe = new Random();
            for (int i = 0; i < Map.Length; i++)
            {
                for (int j = 0; j < Map[i].Length; j++)
                {
                    Map[i][j] = qwe.Next(2);
                }
            }
            Show_Map(Map);

            Console.WriteLine("\nКол-во маршрутов с препядствиями:");
            int[,] b = new int[3, 5];
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[0, j] = 1;
            }
            for (int i = 1; i < b.GetLength(0); i++)
            {
                b[i, 0] = 1;
                for (int j = 1; j < b.GetLength(1); j++)
                {
                    if (Map[i][j] == 1) b[i, j] = b[i - 1, j] + b[i, j - 1];
                    else b[i, j] = 0;
                }
            }
            Show(b);

            // Задача на кол-во вариантов

            Console.Write("\nВведите число --> ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во программ --> {Calc(n)}");
        }

        static int Calc(int n)
        {
            if (n == 1) return 1;
            else if (n > 1 && n % 2 == 0) return Calc(n - 1) + Calc(n / 2);
            else if (n > 1 && n % 2 != 0) return Calc(n - 1);
            return -1;
        }
    }
}

