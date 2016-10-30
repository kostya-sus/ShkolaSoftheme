

namespace HW15_LinkedList
{
    public class Node<T>
    {
        public T NameNode { get; set; }

        public Node<T> NextNode { get; set; }

        public Node<T> PreviousNode { get; set; }

       public Node(T nameNode)
        {
            NameNode = nameNode;
        }
    }
}
