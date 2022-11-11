namespace DataStructures_Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problem");

            Stack stk = new Stack();
            stk.Push(56);
            stk.Push(30);
            stk.Push(70);

            stk.Peek();
            stk.Pop();
            stk.Display();
            stk.Peek();
            stk.Pop();
            stk.Display();
        }
    }
}