using System;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program.");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);

            Console.WriteLine("\n Create Linked List is \n");
            List.Display();

            List.deleteFirstNode();

            Console.WriteLine("\n Linked List after Deletion : ");
            List.Display();
        }
    }
}
