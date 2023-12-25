using DSA_in_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.Algorithms
{
    internal class CircularLinkedList
    {
        public Node_cll head;
        public void insertElement(int value)
        {
            Node_cll newNode = new Node_cll(value);
            if(head == null)
            {
                head = newNode;
                head.next = newNode;
            }
            else
            {
                Node_cll traverse = head;
                while (traverse.next != head)
                {
                    traverse = traverse.next;
                }
                traverse.next = newNode;
                newNode.next = head;
            }
        }
        public void removeElement()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                if (head.next == head)
                {
                    Console.WriteLine($"Deleted element is: {head.value}");
                    head = null;
                }
                else
                {
                    Node_cll traverse = head;
                    Node_cll secondLastNode = head;
                    while (traverse.next != head)
                    {
                        secondLastNode = traverse;
                        traverse = traverse.next;
                    }
                    Console.WriteLine($"Deleted element is: {traverse.value}");
                    secondLastNode.next = head;

                }
            }
        }
        public void displayList()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write($"Elements in list are: ");
                Node_cll traverse = head;
                while (traverse.next != head)
                {
                    Console.Write($"{traverse.value} ");
                    traverse = traverse.next;
                }
                Console.Write(traverse.value);
            }
        }
        public void LengthOfList()
        {
            if(head == null)
            {
                Console.WriteLine("Length of list is: 0");
            }
            else
            {
                int length = 0;
                Console.Write($"Length of list is: ");
                Node_cll traverse = head;
                while(traverse.next != head)
                {
                    length++;
                    traverse = traverse.next;
                }
                Console.WriteLine(length + 1);
            }
        }
    }
}
