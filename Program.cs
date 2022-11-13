using System.Collections.Generic;

namespace DataStructures_Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problem");

            Queue objList = new Queue();
            objList.Enqueue(56);
            objList.Enqueue(30);
            objList.Enqueue(70);
            objList.Display();
            objList.Dequeue();
            objList.Display();

        }
    }
}