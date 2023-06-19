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
            for (int i = 0; i < count -1; i++) // Iterates through the list
            {
                DoublyLinkedListNode<T> current = List.Head;
                for (int j = 0; j < count - 1 - i; j++)
                {
                    DoublyLinkedListNode<T> nextNode = current.Next;
                    if (current.GetHashCode() > nextNode.GetHashCode())
                    {
                        T temp = current.Value;
                        current.Value = nextNode.Value;
                        nextNode.Value = temp;
                    }
                    current = current.Next;
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


        /* Searching Algoritms */
        // Binary Search



        // Sequential Search
    }
}
