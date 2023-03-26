using Problem04.SinglyLinkedList;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mySinglyLinkedList = new SinglyLinkedList<int>();
            mySinglyLinkedList.AddFirst(1);
            mySinglyLinkedList.AddFirst(3);
            mySinglyLinkedList.AddFirst(5);
            mySinglyLinkedList.AddFirst(7);

            mySinglyLinkedList.AddLast(2);
            mySinglyLinkedList.AddLast(4);
            mySinglyLinkedList.AddLast(6);
            mySinglyLinkedList.AddLast(8);

            Console.WriteLine($"Removed the first element =>  {mySinglyLinkedList.RemoveFirst()}");
            Console.WriteLine($"Removed the last element =>  {mySinglyLinkedList.RemoveLast()}");

            foreach (var item in mySinglyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}