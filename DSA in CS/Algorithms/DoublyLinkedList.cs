using DSA_in_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class DoublyLinkedList
    {
        public Node_dll head_dll;
        public Node_dll tail_dll;
        public void addEnd(int value)
        {
            Node_dll newNode = new Node_dll(value);
            if(head_dll == null)
            {
                head_dll = tail_dll = newNode;
            }
            else
            {
                tail_dll.next = newNode;
                newNode.previous = tail_dll;
                tail_dll = newNode;
            }
        }
        public void addFront(int value)
        {
            Node_dll newNode = new Node_dll(value);
            if(head_dll == null)
            {
                head_dll = tail_dll = newNode;
            }
            else
            {
                newNode.next = head_dll;
                head_dll.previous = newNode;
                head_dll = newNode;
            }
        }
        public void deleteEnd()
        {
            if(head_dll == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine($"Deleted element is: {tail_dll.value}");
                if(head_dll.next == null)
                {
                    head_dll = tail_dll = null;
                }
                else
                {
                    tail_dll = tail_dll.previous;
                    tail_dll.next = null;
                }
            }
        }
        public void deleteFront()
        {
            if(head_dll == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine($"Deleted element is: {head_dll.value}");
                if (head_dll.next == null)
                {
                    head_dll = tail_dll = null;
                }
                else
                {
                    Node_dll secondNode = head_dll.next;
                    secondNode.previous = null;
                    head_dll = secondNode;
                }
            }
        }
        public void deleteSpecific(int value)
        {
            if (head_dll == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node_dll traverse = head_dll;
                bool flag = false;
                while(traverse != null)
                {
                    if(traverse.value == value)
                    {
                        flag = true;
                        break;
                    }
                    traverse = traverse.next;
                }

                if (flag)
                {
                    if (traverse.next == null)
                    {
                        deleteEnd();
                    }
                    else if (traverse.previous == null)
                    {
                        deleteFront();
                    }
                    else
                    {
                        Node_dll previousNode = traverse.previous;
                        Node_dll next_Node = traverse.next;
                        previousNode.next = next_Node;
                        next_Node.previous = previousNode;
                    }
                    Console.WriteLine("Element deleted.");
                }
                else
                {
                    Console.WriteLine("Element is not present in the list");
                }
            }
        }
        public void displayFromFront()
        {
            if(head_dll == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node_dll traverse = head_dll;
                Console.Write("Elements in list are: ");
                while (traverse != null)
                {
                    Console.Write($"{traverse.value} ");
                    traverse = traverse.next;
                }
            }
        }
        public void displayFromEnd()
        {
            if(head_dll == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node_dll traverse = tail_dll;
                Console.Write("Elements is Reverse are: ");
                while(traverse != null)
                {
                    Console.Write($"{traverse.value} ");
                    traverse = traverse.previous;
                }
            }
        }
    }
}
