using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Stack_Queue
{
    internal class Queue
    {
        public Node head;
        public Node tail;

        public Queue()
        {
            this.head = this.tail = null;
        }

        public void Enqueue(int data)
        {
            Node objNode = new Node(data);
            if (this.tail == null)
            {
                this.head = this.tail = objNode;
            }
            else
            {
                this.tail.next = objNode;
                this.tail = objNode;
            }
            Console.WriteLine($"\n{data} is inserted into the Queue");
        }
        
        public void Display()
        {
            int size = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is empty");
                return;
            }
            Console.Write("\nQueue : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nNo. of Elements in Queue: " + size);
        }
    }
}
