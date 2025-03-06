using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2z0_6
{
    public class LinkedListNode
    {
        public int Value;
        public LinkedListNode Next;

        public LinkedListNode(int value = 0, LinkedListNode next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
