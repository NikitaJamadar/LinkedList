﻿using System;

namespace UC8
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
            List.Display();
            List.insert(2, 40);
            List.Display();
        }
    }
}
