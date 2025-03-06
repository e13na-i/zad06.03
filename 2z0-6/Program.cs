namespace _2z0_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            int[] valuesOdd = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            LinkedListNode headOdd = linkedList.CreateList(valuesOdd);
            linkedList.PrintList(headOdd);

            LinkedListNode middleNode = linkedList.FindMiddle(headOdd);
            Console.WriteLine("Среден възел: " + middleNode.Value);
        }
    }
}
