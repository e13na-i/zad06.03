using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad06._03
{
    public class DoubleLinkedListNode
    {
        public int Value;
        public DoubleLinkedListNode Next;
        public DoubleLinkedListNode Prev;

        public DoubleLinkedListNode(int value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }
    }
}
