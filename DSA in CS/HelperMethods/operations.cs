using System;
using System.Linq;
using System.Text;
using DSA_in_CS.Algorithms;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using DSA_in_CS.Searching;
using DSA_in_CS.Sorting;

namespace DSA_in_CS.HelperMethods
{
    internal class operations
    {
        helperMethods _helperMethods = new helperMethods();
        SampleLists sampleLists = new SampleLists();
        public void stackOperations()
        {
            Algorithms.Stack stack = new Algorithms.Stack();
            int stack_operation = 0;

            do
            {
                stack_operation = _helperMethods.stackMenu();

                switch (stack_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        stack.push(value);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        stack.pop();
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        stack.peek();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        stack.display();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting Stack...");
                        break;

                    default:
                        Console.WriteLine("Invalid Operation !");
                        break;
                }

            } while (stack_operation != 5);
        }
        public void queueOperations()
        {
            Algorithms.Queue queue = new Algorithms.Queue();
            int queue_operation = 0;

            do
            {
                queue_operation = _helperMethods.queueMenu();

                switch (queue_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        queue.insertQ(value);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        queue.removeQ();
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        queue.displayQ();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting Queue...");
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            }while(queue_operation != 4);
        }
        public void circularQueueOperations()
        {
            CircularQueue circular_queue = new CircularQueue();
            int queue_operation = 0;

            do
            {
                queue_operation = _helperMethods.queueMenu();
                switch(queue_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        circular_queue.insertQ(value);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        circular_queue.removeQ();
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        circular_queue.displayQ();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting Queue...");
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (queue_operation != 4);
        }
        public void linkedListOperations()
        {
            LinkedList ll = new LinkedList();
            int ll_operation = 0;

            do
            {
                ll_operation = _helperMethods.linkedListMenu();
                switch (ll_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value_end = Convert.ToInt32(Console.ReadLine());
                        ll.insertEnd(value_end);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value_begin = Convert.ToInt32(Console.ReadLine());
                        ll.insertStart(value_begin);
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        ll.removeEnd();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        ll.removeStart();
                        break;

                    case 5:
                        Console.WriteLine(new string('-', 50));
                        ll.display();
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting LinkedList...");
                        break;

                    default:
                        break;
                }
            }while(ll_operation != 6);
        }
        public void doublyLinkedListOperation()
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            int dll_operation = 0;

            do
            {
                dll_operation = _helperMethods.doublyLinkedListMenu();
                switch(dll_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value_front = Convert.ToInt32(Console.ReadLine());
                        dll.addEnd(value_front);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value_end = Convert.ToInt32(Console.ReadLine());
                        dll.addFront(value_end);
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        dll.deleteEnd();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        dll.deleteFront();
                        break;

                    case 5:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        dll.deleteSpecific(value);
                        break;

                    case 6:
                        Console.WriteLine(new string('-', 50));
                        dll.displayFromFront();
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine(new string('-', 50));
                        dll.displayFromEnd();
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting Doubly LinkedList...");
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (dll_operation != 8);
        }
        public void circularLinkedListOperation()
        {
            CircularLinkedList cll = new CircularLinkedList();
            int cll_operation = 0;

            do
            {
                cll_operation = _helperMethods.circularLinkedListMenu();
                switch (cll_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        cll.insertElement(value);
                        break;

                    case 2:
                        Console.WriteLine(new string('-', 50));
                        cll.removeElement();
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        cll.displayList();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        cll.LengthOfList();
                        break;

                    case 5:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Exiting circular linked list...");
                        break;

                    default:
                        Console.WriteLine("Invalid Operation !");
                        break;
                }
            } while( cll_operation != 5);
        }
        public void bstOperation()
        {
            BinarySearchTree bst = new BinarySearchTree();
            int bst_operation = 0;

            do
            {
                bst_operation = _helperMethods.binarySearchTreeMenu();
                switch(bst_operation)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        Console.Write("Enter a value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        bst.insert(value);
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.WriteLine(new string('-', 50));
                        bst.emptyCondition("inorder");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine(new string('-', 50));
                        bst.emptyCondition("preorder");
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine(new string('-', 50));
                        bst.emptyCondition("postorder");
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine($"Height of tree is: {bst.calculateHeight()}");
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            } while (bst_operation != 7);
        }
        public void binarySearch()
        {
            BinarySearch bs = new BinarySearch();
            Console.WriteLine(new string('-', 50));
            Console.Write("Enter a value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.sortedOddList)}\nElement found at index: {bs.BinarySearchValue(sampleLists.sortedOddList, value)}");
            Console.WriteLine($"List : {string.Join(", ", sampleLists.emptyList)}\nElement found at : {bs.BinarySearchValue(sampleLists.emptyList, value)}");
            Console.WriteLine($"List : {string.Join(", ", sampleLists.sortedEvenList)}\nElement found at : {bs.BinarySearchValue(sampleLists.sortedEvenList, value)}");
        }
        public void linearSearch()
        {
            LinearSearch ls = new LinearSearch();
            Console.WriteLine(new string('-', 50));
            Console.Write("Enter a value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.emptyList)}\nElement found at index: {ls.LinearSearchValue(sampleLists.emptyList, value)}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.sizeOne)}\nElement found at index: {ls.LinearSearchValue(sampleLists.sizeOne, value)}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.sortedOddList)}\nElement found at index: {ls.LinearSearchValue(sampleLists.sortedOddList, value)}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.sortedEvenList)}\nElement found at index: {ls.LinearSearchValue(sampleLists.sortedEvenList, value)}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.oddList)}\nElement found at index: {ls.LinearSearchValue(sampleLists.oddList, value)}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"List : {string.Join(", ", sampleLists.evenList)}\nElement found at index: {ls.LinearSearchValue(sampleLists.evenList, value)}");            
        }

        public void bubbleSort()
        {
            BubbleSort buS = new BubbleSort();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.oddList)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.oddList))}");
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.evenList)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.evenList))}");
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.sortedOddList)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.sortedOddList))}");
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.sortedEvenList)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.sortedEvenList))}");
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.emptyList)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.emptyList))}");
            Console.WriteLine($"Og. Array: {string.Join(", ", sampleLists.sizeOne)}\nSo. Array: {string.Join(", ", buS.BubbleSortArray(sampleLists.sizeOne))}");
        }
    }
}
