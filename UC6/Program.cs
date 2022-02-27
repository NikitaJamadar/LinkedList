using System;

namespace UC6
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

            List.deleteNode(2);

            Console.WriteLine("\n Linked List after Deletion: ");
            List.Display();
        }
    }
}
