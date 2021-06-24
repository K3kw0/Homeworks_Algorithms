using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace lesson_3
{
    public class PointClass
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    public struct PointStruct
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    public struct PointStructd
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {
        public float PointDistanceShortClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public void TestPointDistanceShortClass()
        {
            PointClass pointOne = new PointClass()
            {
                X = 55,
                Y = 33,
            };
            PointClass pointTwo = new PointClass()
            {
                X = 66,
                Y = 89,
            };
            Console.WriteLine(PointDistanceShortClass(pointOne, pointTwo));
        }

        public float PointDistanceShortStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public void TestPointDistanceShortStruct()
        {
            PointStruct pointOne = new PointStruct()
            {
                X = 10,
                Y = 7,
            };
            PointStruct pointTwo = new PointStruct()
            {
                X = 6,
                Y = 2,
            };
            Console.WriteLine(PointDistanceShortStruct(pointOne, pointTwo));
        }

        public double PointDistanceShortStructd(PointStructd pointOne, PointStructd pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public void TestPointDistanceShortStructd()
        {
            PointStructd pointOne = new PointStructd()
            {
                X = 10.63,
                Y = 7.89,
            };
            PointStructd pointTwo = new PointStructd()
            {
                X = 6.51,
                Y = 2.02,
            };
            Console.WriteLine(PointDistanceShortStructd(pointOne, pointTwo));
        }

        public float PointDistanceShortStruct1(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        [Benchmark]
        public void TestPointDistanceShortStruct1()
        {
            PointStruct pointOne = new PointStruct()
            {
                X = 10,
                Y = 7,
            };
            PointStruct pointTwo = new PointStruct()
            {
                X = 6,
                Y = 2,
            };
            Console.WriteLine(PointDistanceShortStruct1(pointOne, pointTwo));
        }
    }
}