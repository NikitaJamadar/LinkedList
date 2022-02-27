using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program.");
            LinkedList List = new LinkedList();
            List.AddLast(70);
            List.AddFirst(30);
            List.AddFirst(56);
            List.Display();
        }
    }
}
