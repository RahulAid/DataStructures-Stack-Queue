using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Stack_Queue
{
    internal class Stack
    {
        public Node head;

        public Stack()
        {
            this.head = null;
        }

        public void Push(int data)
        {
            Node objNode = new Node(data);
            if (head == null)
            {
                objNode.next = null;
            }
            else
            {
                objNode.next = head;
            }
            head = objNode;
            Console.WriteLine($"{data} pushed to Stack");
        }

        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("\nEmpty Stack");
                return;
            }
            Console.WriteLine($"\n{head.data} is on the top of the Stack");
        }

        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("\nEmpty Stack");
                return;
            }
            Console.WriteLine($"\nPopped Element : {head.data}");
            head = head.next;
        }

        public void Display()
        {
            int size = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nStack is empty");
                return;
            }
            Console.Write("\nStack Elements : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nTotal Elements in Stack: " + size);
        }
    }
}
