
using System.Collections.Generic;

namespace HW16_Stack
{
    public class Stack<TValue> 
    {
        private List<TValue> _stack;

        public Stack()
        {
            _stack = new List<TValue>();
        }

        public int Count
        {
            get { return _stack.Count; }
        }

        public TValue Peek()
        {
            return _stack[0];
        }

        public TValue Pop()
        {
            var item = _stack[0];
            _stack.RemoveAt(0);
            return item;
        }

        public void Push(TValue item)
        {
            _stack.Insert(0, item);
        }
    }
}
