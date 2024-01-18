using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_CS.HelperMethods
{
    internal class helperMethods
    {
        public int mainMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Stack\n" +
                "2. Queue\n" +
                "3. Circular Queue\n" +
                "4. Linked List\n" +
                "5. Doubly LL\n" +
                "6. Circular LL\n" +
                "7. Binary Search tree\n" +
                "------------------------\n" +
                "8. Binary Search\n" +
                "9. Linear Search\n" +
                "------------------------\n" +
                "10. Bubble Sort\n" +
                "11. Selection Sort\n" +
                "12. Insertion Sort\n" +
                "------------------------\n" +
                "13. Exit");
            Console.Write("Choose Algorithm: ");
            int algo = 0;
            if (!int.TryParse(Console.ReadLine(), out algo))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine(new string('-', 50));
            return algo;
        }
        public int stackMenu() {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
            "1. Push\n" +
            "2. Pop\n" +
            "3. Peek\n" +
            "4. Display\n" +
            "5. Exit");
            Console.Write("Enter Operation: ");
            int stack_operation = 0;
            if (!int.TryParse(Console.ReadLine(), out stack_operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return stack_operation;
        }
        
        //Can also be used with circular queue
        public int queueMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Insert\n" +
                "2. Remove\n" +
                "3. Display\n" +
                "4. Exit");
            Console.Write("Enter Operation: ");
            int queue_operation = 0;
            if (!int.TryParse(Console.ReadLine(), out queue_operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return queue_operation;
        }
        public int linkedListMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Insert End\n" +
                "2. Insert Beginning\n" +
                "3. Remove End\n" +
                "4. Remove Beginning\n" +
                "5. Display\n" +
                "6. Exit");
            Console.Write("Enter Operation: ");
            int ll_operation = 0;
            if(!int.TryParse(Console.ReadLine(), out ll_operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return ll_operation;
        }
        public int doublyLinkedListMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Insert End\n" +
                "2. Insert Beginning\n" +
                "3. Remove End\n" +
                "4. Remove Beginning\n" +
                "5. Remove specific node\n" +
                "6. Display from Beginning\n" +
                "7. Display from End\n" +
                "8. Exit");
            Console.Write("Enter Operation: ");
            int dll_operation = 0;
            if (!int.TryParse(Console.ReadLine(), out dll_operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return dll_operation;
        }
        public int circularLinkedListMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Insert\n" +
                "2. Remove\n" +
                "3. Display\n" +
                "4. Length\n" +
                "5. Exit");
            Console.Write("Enter Operation: ");
            int cll_operation = 0;
            if (!int.TryParse(Console.ReadLine(), out cll_operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return cll_operation;
        }
        public int binarySearchTreeMenu()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "1. Insert\n" +
                "2. Remove\n" +
                "3. Inorder traversal\n" +
                "4. Preorder traversal\n" +
                "5. Postorder traversal\n" +
                "6. Height\n" +
                "7. Exit");
            Console.Write("Enter Operation: ");
            int bst_Operation = 0;
            if (!int.TryParse(Console.ReadLine(), out bst_Operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return bst_Operation;
        }
    }
}
