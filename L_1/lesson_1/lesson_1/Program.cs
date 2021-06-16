using System;
using System.IO;

namespace sdjgdhfg
{
    //public class TestCase
    //{
    //    public int X { get; set; }
    //    public string Expected { get; set; }
    //    public Exception ExpectedException { get; set; }
    //}

    class Program
    {
        //static string SimpleOrNo(int n)
        //{
        //    int d = 0;
        //    int i = 2;

        //    if (n < 0)
        //    {
        //        throw new Exception("Введите положительное число!");
        //    }
        //    else
        //    {
        //        while (i < n)
        //        {
        //            if (n % i == 0)
        //            {
        //                d++;
        //                break;
        //            }
        //            else i++;
        //        }
        //    }
        //    if (d == 0) return "Простое";
        //    else return "Не простое";
        //}

        //static void Test(TestCase simple)
        //{
        //    try
        //    {
        //        var actual = SimpleOrNo(simple.X);

        //        if (actual == simple.Expected) Console.WriteLine("VALID TEST");
        //        else Console.WriteLine("INVALID TEST");
        //    }
        //    catch (Exception ex)
        //    {
        //        if (simple.ExpectedException != null) Console.WriteLine("VALID TEST");
        //        else Console.WriteLine($"INVALID TEST --> {ex.Message}");
        //    }
        //}
                                                      //// задание 1
        //static void Main(string[] args)
        //{
        //    TestCase test0 = new TestCase()
        //    {
        //        X = -6,
        //        Expected = "Не простое",
        //    };
        //    Test(test0);

        //    TestCase test1 = new TestCase()
        //    {
        //        X = -6,
        //        ExpectedException = new Exception("Введите положительное число!"),
        //    };
        //    Test(test1);

        //    TestCase test2 = new TestCase()
        //    {
        //        X = 3,
        //        Expected = "Простое",
        //    };
        //    Test(test2);

        //    TestCase test3 = new TestCase()
        //    {
        //        X = 4,
        //        Expected = "Не простое",
        //    };
        //    Test(test3);

        //    TestCase test4 = new TestCase()
        //    {
        //        X = 5,
        //        Expected = "Не простое",
        //    };
        //    Test(test4);
        //}
                                                   //// задание 3
        //static void Main(string[] args)
        //{
        //    Test t = new Test();
        //    t.X = -8;
        //    Test(t);

        //    Test t1 = new Test();
        //    t1.X = 8;
        //    t1.Assumption = 21;
        //    Test(t1);

        //    Test t2 = new Test();
        //    t2.X = 2;
        //    t2.Assumption = 3;
        //    Test(t2);

        //    Test t3 = new Test();
        //    t3.X = 3;
        //    t3.Assumption = 2;
        //    Test(t3);

        //    Test t4 = new Test();
        //    t4.X = 4;
        //    t4.Assumption = 3;
        //    t4.Exx = new Exception("Введите положительное число!");
        //    Test(t4);

        //    Console.WriteLine("\nДля рекурсии:");
        //    Test t5 = new Test();
        //    t5.X = -5;
        //    Test(t5);

        //    Test t6 = new Test();
        //    t6.X = 8;
        //    t6.Assumption = 21;
        //    Test(t6);

        //    Test t7 = new Test();
        //    t7.X = 2;
        //    t7.Assumption = 3;
        //    Test(t7);

        //    Test t8 = new Test();
        //    t8.X = 3;
        //    t8.Assumption = 2;
        //    Test(t8);

        //    Test t9 = new Test();
        //    t9.X = 4;
        //    t9.Assumption = 3;
        //    t9.Exx = new Exception("Введите положительное число!");
        //    Test(t9);

        //}

        //static int FibRek(int n)
        //{
        //    if (n < 0) throw new Exception("Введите положительное число!");
        //    else if (n == 0 || n == 1) return n;
        //    else return FibRek(n - 1) + FibRek(n - 2);
        //}

        //static int Fibb(int n)
        //{
        //    int a = 0;
        //    int b = 1;

        //    if (n < 0) throw new Exception("Введите положительное число!");
        //    else
        //    {
        //        for (int i = 1; i < n; i++)
        //        {
        //            int r = a;
        //            a = b;
        //            b += r;
        //        }
        //    }
        //    return b;
        //}

        //static void Test(Test tt)
        //{
        //    try
        //    {
        //        var OK = Fibb(tt.X);
        //        var OK1 = FibRek(tt.X);

        //        if (OK == tt.Assumption || OK1 == tt.Assumption) Console.WriteLine("OK");
        //        else Console.WriteLine("SAD");
        //    }
        //    catch (Exception ex)
        //    {
        //        if (tt.Exx != null) Console.WriteLine("OK");
        //        else Console.WriteLine($"SAD --> {ex.Message}");
        //    }
        //}
    }

    //class Test
    //{
    //    public int X { get; set; }
    //    public int Assumption { get; set; }
    //    public Exception Exx { get; set; }
    //}
}