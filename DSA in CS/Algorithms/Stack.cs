using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class Stack
    {
        int top = -1;
        int[] stack = new int[5];
        public void push(int val)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                top++;
                stack[top] = val;
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.WriteLine($"Deleted element is: {stack[top]}");
                top--;
            }
        }
        public void peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.WriteLine($"Element at top: {stack[top]}");
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.Write("Elements in stack are: ");
                for (int i = 0; i <= top ; i++)
                {
                    Console.Write($"{stack[i]} ");
                }
            }
        }
    }
}
