using System;


namespace HW15_LinkedList
{
    class Program
    {
        private static void Main(string[] args)
        {
            DoubleLinkedList<int> listInt = new DoubleLinkedList<int>();
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node9 = new Node<int>(9);


            listInt.Add(node1);
            listInt.Add(node2);
            listInt.Add(node3);
            listInt.Add(node9);



            try
            {
                listInt.RemoveByIndex(1);
               
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


            Console.WriteLine( listInt.Contains(node2));
            Console.WriteLine(listInt.Contains(node9));

            var a = listInt.ToArray();

            foreach (var elem in a)
            {
                Console.WriteLine(elem.NameNode);
            }
            Console.ReadKey();
        }
    }
}
