using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class CircularQueue
    {
        int[] queue = new int[5];
        int size = 5;
        int front = -1;
        int rear = -1;

        public void insertQ(int value)
        {
            if (((rear == size - 1) & (front == 0) || front == (rear + 1)%size))
            {
                Console.WriteLine("Queue overflow");
            }
            else
            {
                if(rear == -1)
                {
                    front = rear = 0;
                }
                else
                {
                    rear = (rear + 1)%size;
                }
                queue[rear] = value;
            }
        }
        public void removeQ()
        {
            if (rear == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine($"Deleted value is: {queue[front]}");
                if(front == rear)
                {
                    front = rear = -1;
                }
                else
                {
                    front = (front + 1)%size;
                }
            }
        }
        public void displayQ()
        {
            if(rear == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.Write("Elements in queue are: ");
                if (rear >= front)
                {
                    for(int i = front; i<=rear; i++)
                    {
                        Console.Write($"{queue[i]} ");
                    }
                }
                else
                {
                    for(int i = front; i<size; i++)
                    {
                        Console.Write($"{queue[i]} ");
                    }
                    for(int j = 0; j <= rear; j++)
                    {
                        Console.Write($"{queue[j]} ");
                    }
                }
            }
        }
    }
}
