using DSA_in_CS.Algorithms;
using DSA_in_CS.HelperMethods;
using DSA_in_CS.Searching;

Console.WriteLine("Hello World");
helperMethods _helperMethods = new helperMethods();
operations _operations = new operations();

int algo = 0;

do
{
    algo = _helperMethods.mainMenu();

    switch (algo)
    {
        // Stack
        case 1:
            _operations.stackOperations();
            break;

        // Queue
        case 2:
            _operations.queueOperations();
            break;

        // Circular Queue
        case 3:
            _operations.circularQueueOperations();
            break;

        // Linked List
        case 4:
            _operations.linkedListOperations();
            break;

        // Doubly Linked List
        case 5:
            _operations.doublyLinkedListOperation();
            break;

        // Circular Linked List
        case 6:
            _operations.circularLinkedListOperation();
            break;

        // Binary Search Tree
        case 7:
            _operations.bstOperation();
            break;

        case 8:
            _operations.binarySearch();
            break;

        case 9:
            _operations.linearSearch();
            break;

        case 10:
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Exiting application...");
            break;

        default:
            Console.WriteLine("Invalid Input");
            break;
    }
    
} while (algo != 10);