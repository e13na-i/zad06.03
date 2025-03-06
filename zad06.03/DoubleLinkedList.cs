using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad06._03
{
    public class DoubleLinkedList
    {
        public DoubleLinkedListNode Head;

        public DoubleLinkedList()
        {
            Head = null;
        }

        public void Add(int value)
        {
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                DoubleLinkedListNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Prev = current;
            }
        }

        public void Reverse()
        {
            if (Head == null)
                return;

            DoubleLinkedListNode prevNode = null;
            DoubleLinkedListNode currNode = Head;
            while (currNode != null)
            {
                DoubleLinkedListNode nextNode = currNode.Next;
                currNode.Next = prevNode;
                currNode.Prev = nextNode;

                prevNode = currNode;
                currNode = nextNode;
            }
            Head = prevNode;
        }

        public void PrintList()
        {
            DoubleLinkedListNode current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
