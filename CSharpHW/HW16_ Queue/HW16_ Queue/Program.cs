using System;


namespace HW16__Queue
{
    
        class Program
        {
            private const int EnqueueItemCount = 5;
            private const int DequeuItemCount = 2;
            
            static void Main(string[] args)
            {
                                   
              var myQueue = new Queue<int>();
              Console.WriteLine("Queue(FIFO principle)");

              for (int i = 0; i < EnqueueItemCount; i++)
              {
                myQueue.Enqueue(i);
              }

              Console.WriteLine("Queue contains: {0}", myQueue.Count);
              Console.WriteLine("Get some values from queue ");
             
              for (int i = 0; i < DequeuItemCount; i++)
              {
                Console.WriteLine("Delete Value = {0}. Now items in queue: {1}.", myQueue.Dequeue(), myQueue.Count);
              }

              Console.WriteLine("Put in queue ");

              for (int i = 0; i < EnqueueItemCount; i++)
              {
                myQueue.Enqueue(i);
              }

              Console.WriteLine("Queue contains: {0}", myQueue.Count);
              Console.WriteLine("Get the first item in queue : ");
              Console.WriteLine("value = {0}", myQueue.Peek());
              Console.ReadLine();
            

           
            }
        }
    
}
