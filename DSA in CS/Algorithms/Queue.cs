using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class Queue
    {

        int front, rear = -1;
        int[] queue = new int[5];
        public void insertQ(int val)
        {
            if (rear == queue.Length - 1)
            {
                Console.WriteLine("Queue overflow");
            }
            else
            {
                if(front == -1)
                {
                    front = rear = 0;
                }
                else
                {
                    rear++;
                }
                queue[rear] = val;
            }
        }
        public void removeQ()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue underflow");
            }
            else
            {
                Console.WriteLine($"Deleted element is: {queue[front]}");
                if (front == rear)
                {
                    front = rear = -1;
                }
                else
                {
                    front++;
                }
            }
        }
        public void displayQ()
        {
            if(rear == -1)
            {
                Console.WriteLine("Queue underflow");
            }
            else
            {
                Console.Write("Elements of Queue are: ");
                for (int i = front; i<=rear; i++)
                {
                    Console.Write($"{queue[i]} ");
                }
            }
        }
    }
}
