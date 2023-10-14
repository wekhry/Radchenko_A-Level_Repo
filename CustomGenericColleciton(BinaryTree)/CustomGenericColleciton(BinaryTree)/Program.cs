using CustomGenericColleciton_BinaryTree_.BinarySearch;
using CustomGenericColleciton_BinaryTree_.BinaryTree;
using CustomGenericColleciton_BinaryTree_.CircularDoublyLinkedList;

namespace CustomGenericColleciton_BinaryTree_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Binary Tree 
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(7);
            binaryTree.Add(2);
            binaryTree.Add(4);
            binaryTree.Add(6);
            binaryTree.Add(8);

            Console.WriteLine("Binary Tree Pre-Order Traversal: ");
            foreach (var value in binaryTree.PreOrderTraversal())
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Binary Tree In-Order Traversal: ");
            foreach (var value in binaryTree.InOrderTraversal())
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Binary Tree Post-Order Traversal: ");
            foreach (var value in binaryTree.PostOrderTraversal())
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            //Circular Doubly Linked List
            CircularDoublyLinkedList<string> linkedList = new CircularDoublyLinkedList<string>();
            linkedList.Add("a");
            linkedList.Add("b");
            linkedList.Add("c");
            linkedList.Add("d");

            Console.WriteLine("Circular Doubly Linked List: ");
            foreach (var value in linkedList)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Element at index 1: " + linkedList[1]);

            linkedList.Remove("b");

            Console.WriteLine("Circular Doubly Linked List after removing 'b': ");
            foreach (var value in linkedList)
            {
                Console.WriteLine(value + " ");
            }
            Console.WriteLine();

            //Binary Search 
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int index = array.BinarySearchTree(12);

            Console.WriteLine("Array: " + string.Join(", ", array));

            Console.WriteLine("Index of value 12 in the array: " + index);

            Console.ReadLine();
        }
    }
}
