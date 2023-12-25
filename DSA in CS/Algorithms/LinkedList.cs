using DSA_in_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{

    internal class LinkedList
    {
        public Node head;
        public void insertEnd(int value)
        {
            if(head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node traverse = head;
                Node newNode = new Node(value);
                while(traverse.next != null)
                {
                    traverse = traverse.next;
                }
                traverse.next = newNode;
            }
        }
        public void insertStart(int value)
        {
            if(head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node newNode = new Node(value);
                newNode.next = head;
                head = newNode;
            }
        }
        public void removeEnd()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                if(head.next == null)
                {
                    Console.WriteLine($"Deleted element is: {head.value}");
                    head = null;
                }
                else
                {
                    Node secondLastNode = head;
                    Node traverse = head;
                    while (traverse.next != null)
                    {
                        secondLastNode = traverse;
                        traverse = traverse.next;
                    }
                    Console.WriteLine($"Deleted element is: {traverse.value}");
                    secondLastNode.next = null;
                }
            }
        }
        public void removeStart()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine($"Deleted value is: {head.value}");
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    head = head.next;
                }
            }
        }
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node traverse = head;
                Console.Write("Elements of list are: ");
                while (traverse != null)
                {
                    Console.Write($"{traverse.value} ");
                    traverse = traverse.next;
                }
            }
        }
    }
}
