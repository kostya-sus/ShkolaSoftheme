
using System.Collections.Generic;


namespace HW16__Queue
{
    public class Queue<TValue> 
    {
        private int _lastIndex;
        private List<TValue> _queue;
                
        public Queue()
        {
            _queue = new List<TValue>();
            _lastIndex = 0;
        }

        public int Count
        {
            get { return _queue.Count; }
        }

        public TValue Dequeue()
        {
            var firstInQueue = _queue[0];
            _queue.RemoveAt(0);
            _lastIndex--;
            return firstInQueue;
        }

        public TValue Peek()
        {
            return _queue[0];
        }

        public void Enqueue(TValue value)
        {
            _queue.Insert(_lastIndex, value);
            _lastIndex++;
        }

        
    }
}
