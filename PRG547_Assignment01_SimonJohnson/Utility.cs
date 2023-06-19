using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Utility
    {
        /* Sorting Algorithms */
        // BubbleSort Ascending
        public void BubbleSortAsc<T>(DoublyLinkedList<T> List)
        {
            int count = List.Count; // Gets the number of elements in the doubly linked list
            for (int i = 0; i < count -1; i++) // Outer loop Iterates through the list
            {
                DoublyLinkedListNode<T> current = List.Head; // Initialises the current variable as the head node
                for (int j = 0; j < count - 1 - i; j++) // Inner loop iterates from the head to the node before the last unsorted element, 
                {
                    DoublyLinkedListNode<T> nextNode = current.Next; // Gets the next node after the current node, compare & swap with current with next node
                    if (current.GetHashCode() > nextNode.GetHashCode()) // Condition to check if current node's hash code is greater than the next node 
                    {
                        T temp = current.Value; // Temporary variable to store the value of the current node
                        current.Value = nextNode.Value; // Assigns the  value of the next node to the current node
                        nextNode.Value = temp; // Assigns stored value of current node (in temp) to the next node
                    }
                    current = current.Next; // Shifts the current node reference to the next node for the next iteration of the inner loop
                }
            }
        }

        // Descending BubbleSort
        public void BubbleSortDesc<T>(DoublyLinkedList<T> List)
        {
            int count = List.Count;
            for (int i = 0; i < count - 1; i++)
            {
                DoublyLinkedListNode<T> current = List.Head;
                for (int j = 0; j < count - 1; j++)
                {
                    DoublyLinkedListNode<T> nextNode = current.Next;
                    if (current.GetHashCode() < nextNode.GetHashCode())
                    {
                        T temp = current.Value;
                        current.Value = nextNode.Value;
                        nextNode.Value = temp;
                    }
                    current = current.Next;
                }
            }
        }
        
        // Get Middle method to 
        public DoublyLinkedListNode<T> GetMiddle<T>(DoublyLinkedListNode<T> left, DoublyLinkedListNode<T> right) // represents leftmost and rightmost nodes
        {
            if (left == null)
                return null;

            DoublyLinkedListNode<T> slow = left; // moves one step at a time
            DoublyLinkedListNode<T> fast = left.Next; // moves two steps at a time
            while (fast != right) // iterates until the fast pointer reaches the right node
            {
                fast = fast.Next; // fast pointer moves one step forward
                if (fast != right) // if the fast pointer is not equal to right, both pointers move ahead
                {
                    slow = slow.Next; // moves one step at a time
                    fast = fast.Next; // moves two steps
                }
            }
            // Speed discrepacy results in the fast node reaching the end (right node), while slow points to the middle node
            // Returns middle node
            return slow;
        }

        /* Searching Algoritms */
        // Binary Search
        // Sort Array[] first
        // Compare x w/ middle element
        // If x matches with middle element, return the middle index
        // elseif x is greater than the mid element, search on right half
        // elseif x is smaller than middle element, search on left half

        private DoublyLinkedListNode<T> BinarySearch<T>(DoublyLinkedList<T> list, T value)
        {
            DoublyLinkedListNode<T> left = list.Head;
            DoublyLinkedListNode<T> right = list.Tail;

            while (left != null && right != null && left != right.Next)
            {
                DoublyLinkedListNode<T> middle = GetMiddle(left, right);
                if (middle.Value.GetHashCode() == 0)
                {
                    return middle;
                }
                else if (middle.Value.GetHashCode() > 0)
                {
                    right = middle.Previous;
                }
                else
                {
                    left = middle.Next;
                }
            }
            return null;
        }




        // Sequential Search
    }
}
