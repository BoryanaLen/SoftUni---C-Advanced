using System;

namespace Workshop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddFirst("3");
            doublyLinkedList.AddFirst("2");
            doublyLinkedList.AddFirst("1");
            doublyLinkedList.AddLast("4");
            doublyLinkedList.AddLast("5");

            doublyLinkedList.Print(Console.WriteLine);

            Console.WriteLine();

            Console.WriteLine(doublyLinkedList.RemoveFirst());

            Console.WriteLine(doublyLinkedList.RemoveLast());

            Console.WriteLine();

            Console.WriteLine(doublyLinkedList.Contains("2"));
            Console.WriteLine(doublyLinkedList.Contains("10"));

            Console.WriteLine();

            doublyLinkedList.Print(Console.WriteLine);
        }
    }
}
