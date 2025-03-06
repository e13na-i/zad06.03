using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2z0_6
{
    public class LinkedList
    {
        public LinkedListNode FindMiddle(LinkedListNode head)
        {
            if (head == null)
                return null;

            LinkedListNode slow_ptr = head;
            LinkedListNode fast_ptr = head;

            while (fast_ptr != null && fast_ptr.Next != null)
            {
                slow_ptr = slow_ptr.Next;     
                fast_ptr = fast_ptr.Next.Next; 
            }

            return slow_ptr;
        }

        public LinkedListNode CreateList(int[] values)
        {
            if (values.Length == 0)
                return null;

            LinkedListNode head = new LinkedListNode(values[0]);
            LinkedListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.Next = new LinkedListNode(values[i]);
                current = current.Next;
            }

            return head;
        }

        public void PrintList(LinkedListNode head)
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
