using System;
using System.IO;
using System.Linq;

namespace lesson_2
{
    //                                                         // задание 1
    //public class Node
    //{
    //    public int Value { get; set; }
    //    public Node NextNode { get; set; }
    //    public Node PrevNode { get; set; }
    //}

    //public interface ILinkedList
    //{
    //    int GetCount(); // возвращает количество элементов в списке
    //    void AddNode(int value); // добавляет новый элемент списка
    //    void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
    //    void RemoveNode(int index); // удаляет элемент по порядковому номеру
    //    void RemoveNode(Node node); // удаляет указанный элемент
    //    Node FindNode(int searchValue); // ищет элемент по его значению
    //}

    //class Qwe : ILinkedList
    //{
    //    private Node firstNode;
    //    private Node lastNode;
    //    private int length = 0;

    //    public void AddNode(int value)
    //    {
    //        Node sup = new Node
    //        {
    //            Value = value,
    //            NextNode = null,
    //            PrevNode = lastNode
    //        };
    //        if (length == 0) firstNode = sup;
    //        else lastNode.NextNode = sup;
    //        lastNode = sup;
    //        length++;
    //    }

    //    public void AddNodeAfter(Node node, int value)
    //    {
    //        Node sup = new Node { Value = value };
    //        Node temp = node.NextNode;
    //        node.NextNode = sup;
    //        sup.NextNode = temp;
    //        sup.PrevNode = node;
    //        if (sup.NextNode == null) lastNode = sup;
    //        length++;
    //    }

    //    public Node FindNode(int searchValue)
    //    {
    //        Node result = null;
    //        Node current = firstNode;
    //        while (current != null)
    //        {
    //            if (current.Value == searchValue)
    //            {
    //                result = current;
    //                break;
    //            }
    //            current = current.NextNode;
    //        }
    //        return result;
    //    }

    //    public int GetCount()
    //    {
    //        return length;
    //    }

    //    public void RemoveNode(int index)
    //    {
    //        int count = 0;
    //        Node current = firstNode;
    //        while (current != null)
    //        {
    //            if (index == count)
    //            {
    //                Node next = current.NextNode;
    //                Node prev = current.PrevNode;
    //                next.PrevNode = prev;
    //                prev.NextNode = next;
    //                length--;
    //                break;
    //            }
    //            current = current.NextNode;
    //            count++;
    //        }
    //    }

    //    public void RemoveNode(Node node)
    //    {
    //        Node next = node.NextNode;
    //        Node prev = node.PrevNode;
    //        next.PrevNode = prev;
    //        prev.NextNode = next;
    //        length--;
    //    }

    //    public void Print()
    //    {
    //        Node current = firstNode;
    //        int counter = 0;
    //        while (current != null)
    //        {
    //            Console.WriteLine(counter + " --> " + current.Value);
    //            current = current.NextNode;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Qwe myList = new Qwe();

    //        myList.AddNode(5);
    //        myList.AddNode(4);
    //        myList.AddNode(3);
    //        myList.Print();
    //        Console.WriteLine("Length = " + myList.GetCount() + "\n");

    //        myList.AddNodeAfter(myList.FindNode(4), 2);
    //        myList.Print();
    //        Console.WriteLine("Length = " + myList.GetCount() + "\n");

    //        myList.RemoveNode(1);
    //        myList.Print();
    //        Console.WriteLine("Length = " + myList.GetCount() + "\n");

    //        myList.RemoveNode(myList.FindNode(2));
    //        myList.Print();
    //        Console.WriteLine("Length = " + myList.GetCount() + "\n");
    //    }

    //                                        // задание 2

    //static void Main(string[] args)
    //{
    //    Console.Write("Исходный массив -->");
    //    int[] q = { 5, 7, 2, 3, 4, 9, 1, 10, 8 };
    //    Print(q);
    //    Array.Sort(q);
    //    Console.Write("Отсортированный массив -->");
    //    Print(q);
    //    Console.Write("Введите число индекс которого нужно найти --> ");
    //    int n = int.Parse(Console.ReadLine());
    //    Console.WriteLine($"Индекс числа {n} --> {Q(q, n)}");

    //    Console.WriteLine("\nПроверки: ");
    //    var r = new Test()
    //    {
    //        A = q,
    //        Zxc = 5,
    //        Expected = 4,
    //    };
    //    Testt(r, 5);

    //    var r1 = new Test()
    //    {
    //        A = q,
    //        Zxc = 7,
    //        Expected = 5,
    //    };
    //    Testt(r1, 7);

    //    var r2 = new Test()
    //    {
    //        A = q,
    //        Zxc = 8,
    //        Expected = 6,
    //    };
    //    Testt(r2, 8);

    //    var r3 = new Test()
    //    {
    //        A = q,
    //        Zxc = 5,
    //        Expected = 6,
    //    };
    //    Testt(r3, 5);

    //    var r4 = new Test()
    //    {
    //        A = q,
    //        Zxc = 8,
    //        Expected = 2,
    //    };
    //    Testt(r4, 8);
    //}

    //static void Print(int[] a)
    //{
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        Console.Write(" " + a[i]);
    //    }
    //    Console.WriteLine();
    //}

    //static int Q(int[] a, int x)
    //{
    //    int min = 0, max = a.Length - 1;
    //    while (min <= max)
    //    {
    //        int mid = (min + max) / 2;
    //        if (x == a[mid]) return mid;
    //        else if (x < a[mid]) max = mid - 1;
    //        else min = mid + 1;
    //    }
    //    return -1;
    //}

    //static void Testt(Test testCase, int x)
    //{
    //    var Ok = Q(testCase.A, x);
    //    if (Ok == testCase.Expected) Console.WriteLine("ok");
    //    else Console.WriteLine("sad");
    //}
    //}

    //class Test
    //{
    //    public int[] A { get; set; }
    //    public int Zxc { get; set; }
    //    public int Expected { get; set; }
    //}
}