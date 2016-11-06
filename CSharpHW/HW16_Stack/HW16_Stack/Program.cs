using System;


namespace HW16_Stack
{
    class Program
    {
        private const int PushItemCount = 10;
        private const int PopItemCount = 6;
        private const int DefaultExtraPushItemCount = 10;
        static void Main(string[] args)
        {
               
            var myStack = new Stack<int>();
            Console.WriteLine("Stack (LIFO principle).");
            Console.WriteLine("Stack push is: {0}", PushItemCount);

            for (int i = 0; i < PushItemCount; i++)
            {
                myStack.Push(i);
                Console.WriteLine("Push. Now items in stack: {0}.",  myStack.Count); 
            }

            Console.WriteLine("Delete some values from stack: {0}", PopItemCount);
          
            for (int i = 0; i < PopItemCount; i++)
            {
                Console.WriteLine("Pop. Value = {0}. Now in stack: {1}.", myStack.Pop(), myStack.Count);
            }
            
            Console.WriteLine("Again push in stack ");

            for (int i = 0; i < PushItemCount; i++)
            {
                myStack.Push(i);
                Console.WriteLine("Push. Now in stack: {0}.", myStack.Count);
            }

            Console.WriteLine("Get the first item in stack ");
            Console.WriteLine("value = {0}", myStack.Peek());

            Console.ReadLine();
        }
        

    }
}
