using System;
using System.Collections.Generic;
using System.Text;

namespace UC5
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void deleteFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                head = head.next;
            }
        }
        internal void Display()
        {
            Node temp =head;
           
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }

    }
}
