using System;


namespace HW15_LinkedList
{
    public class DoubleLinkedList<T>
    {
        private Node<T> n_first;
        private Node<T> n_last;
        private int array_size;

        public int Length
        {
            get
            {
                return array_size;
            }
        }


        public Node<T>[] ToArray()
        {
            Node<T>[] array = new Node<T>[Length];

            var current = n_first;
            var counter = 0;
            while (current != null)
            {
                array[counter] = current;
                current = current.NextNode;
                counter++;
            }

            return array;
        }


        public void Add(Node<T> node)
        {
            if (n_first == null)
            {
                n_first = node;
                n_last = n_first;
            }
            else
            {
                n_last.NextNode = node;
                n_last.NextNode.PreviousNode = n_last;
                n_last = n_last.NextNode;
            }
            array_size++;
        }


       

        public void RemoveByIndex(int index)
        {
           
            int currentIndex = 0;
            Node<T> currentItem = n_first;
            Node<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = currentItem;
                currentItem = currentItem.NextNode;
                currentIndex++;
            }

            if (Length == 0)
            {
                n_first = null;
            }
            else if (prevItem == null)
            {
                n_first = currentItem.NextNode;
                n_first.PreviousNode = null;
            }
            else if (index == Length - 1)
            {
                prevItem.NextNode = currentItem.NextNode;
                n_last = prevItem;
                currentItem = null;
            }
            else
            {
                prevItem.NextNode = currentItem.NextNode;
                currentItem.NextNode.PreviousNode = prevItem;
            }
            array_size--;
        }


        public bool Contains(Node<T> node)
        {
            var current = n_first;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    return true;
                }
                current = current.NextNode;
            }

            return false;
        }


      

    }
}
