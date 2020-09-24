using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class StackLinkedList
    {
        private Node top;

        public StackLinkedList()
        {
            top = null;
        }

        public int Size()
        {
            int size = 0;
            Node p = top;
            while (p != null)
            {
                p = p.link;
                size++;
            }
            return size;
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            x = top.info;
            top = top.link;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return top.info;
        }

        public bool IsEmpty()
        {
            return (top == null);
        }

        public void Display()
        {
            Node p = top;
            if (IsEmpty())
                Console.WriteLine("Stack is empty");
            else
            {
                Console.WriteLine("Stack display: ");
                while (p != null)
                {
                    Console.WriteLine(p.info + " ");
                    p = p.link;
                }
                Console.WriteLine();
            }
        }
    }
}
