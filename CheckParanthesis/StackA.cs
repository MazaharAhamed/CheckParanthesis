using System;
using System.Collections.Generic;
using System.Text;

namespace CheckParanthesis
{
    class StackA
    {
        private char[] stackArray;
        private int top;

        public StackA()
        {
            stackArray = new char[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            stackArray = new char[maxSize];
            top = -1;
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(char x)
        {
            if(isFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }

        public char Pop()
        {
            char x;
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }
    }
}
