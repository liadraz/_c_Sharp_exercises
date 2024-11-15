using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws2
{
    internal class MyStack
    {
        private object[] stack;
        private int maxSize;
        private int top;
        
        public MyStack(int capacity = 10)
        {
            stack = new object[capacity];
            maxSize = capacity;
            top = -1;
        }
        
        public void Push(object value)
        {
            if (IsStackOverflow())
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            top++;
            stack[top] = value;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }

            top--;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Is Empty");
                return -1;
            }

            return stack[top];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }
        public int Size()
        {
            return top + 1;
        }

        public void Clear()
        {
            top = -1;
        }


        // Private Funcs
        private bool IsStackOverflow()
        {
            return (top == maxSize - 1);
        }
    }
}
