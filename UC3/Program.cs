using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program.");
            LinkedList List = new LinkedList();
            List.Append(56);
            List.Append(30);
            List.Append(70);
            List.Display();
        }
    }
}
