namespace zad06._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Оригинален списък:");
            list.PrintList();

            list.Reverse();

            Console.WriteLine("Обърнат списък:");
            list.PrintList();
        }
    }
}
