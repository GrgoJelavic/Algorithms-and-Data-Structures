using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostfixNotationProject
{
    class StackChar
    {
        private char[] stackArray;
        private int top;

        public StackChar()
        {
            stackArray = new Char[10];
            top = -1;
        }

        public StackChar(int MaxSize)
        {
            stackArray = new Char[MaxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(char x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow\n");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }

        public char Pop()
        {
            char x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow\n");
                throw new System.InvalidOperationException();
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }

        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow\n");
                throw new System.InvalidOperationException();
            }
            return stackArray[top];
        }
    }
}
