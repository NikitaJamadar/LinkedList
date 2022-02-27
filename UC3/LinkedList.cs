using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    class LinkedList
    {
        internal Node head;
        internal void Append(int data)
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

        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "-->");
                temp = temp.next;
            }
        }
    }
}
