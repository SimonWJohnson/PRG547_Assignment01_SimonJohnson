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
        public void SingleBubbleSortAsc<T>(LinkedList<T> List)
        {
            try
            {
                int count = List.Count; // Gets the number of elements in the doubly linked list
                for (int i = 0; i < count - 1; i++) // Outer loop Iterates through the list
                {
                    LinkedListNode<T> current = List.Head; // Initialises the current variable as the head node
                    for (int j = 0; j < count - 1 - i; j++) // Inner loop iterates from the head to the node before the last unsorted element, 
                    {
                        LinkedListNode<T> nextNode = current.Next; // Gets the next node after the current node, compare & swap with current with next node
                        if (current.Value.GetHashCode() > nextNode.Value.GetHashCode()) // Condition to check if current node's hash code is greater than the next node 
                        {
                            T temp = current.Value; // Temporary variable to store the value of the current node
                            current.Value = nextNode.Value; // Assigns the  value of the next node to the current node
                            nextNode.Value = temp; // Assigns stored value of current node (in temp) to the next node
                        }
                        current = current.Next; // Shifts the current node reference to the next node for the next iteration of the inner loop
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SingleBubbleSortAsc method {ex}");
            }
        }


        // BubbleSort Ascending
        public void BubbleSortAsc<T>(DoublyLinkedList<T> List)
        {
            try
            {
                int count = List.Count; // Gets the number of elements in the doubly linked list
                for (int i = 0; i < count - 1; i++) // Outer loop Iterates through the list
                {
                    DoublyLinkedListNode<T> current = List.Head; // Initialises the current variable as the head node
                    for (int j = 0; j < count - 1 - i; j++) // Inner loop iterates from the head to the node before the last unsorted element, 
                    {
                        DoublyLinkedListNode<T> nextNode = current.Next; // Gets the next node after the current node, compare & swap with current with next node
                        if (current.Value.GetHashCode() > nextNode.Value.GetHashCode()) // Condition to check if current node's hash code is greater than the next node 
                        {
                            T temp = current.Value; // Temporary variable to store the value of the current node
                            current.Value = nextNode.Value; // Assigns the  value of the next node to the current node
                            nextNode.Value = temp; // Assigns stored value of current node (in temp) to the next node
                        }
                        current = current.Next; // Shifts the current node reference to the next node for the next iteration of the inner loop
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in BubbleSortAsc method {ex}");
            }
        }

        // Descending BubbleSort
        // 
        public void BubbleSortDesc<T>(DoublyLinkedList<T> List)
        {
            try
            {
                int count = List.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    DoublyLinkedListNode<T> current = List.Head;
                    for (int j = 0; j < count - 1; j++)
                    {
                        DoublyLinkedListNode<T> nextNode = current.Next;
                        if (current.Value.GetHashCode() < nextNode.Value.GetHashCode())
                        {
                            T temp = current.Value;
                            current.Value = nextNode.Value;
                            nextNode.Value = temp;
                        }
                        current = current.Next;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in BubbleSortDesc method {ex}");
            }
        }

        // Get Middle method
        public DoublyLinkedListNode<T> GetMiddle<T>(DoublyLinkedListNode<T> left, DoublyLinkedListNode<T> right) // represents leftmost and rightmost nodes
        {
            try
            {

                DoublyLinkedListNode<T> slow = left; // moves one step at a time
                DoublyLinkedListNode<T> fast = left; // moves two steps at a time
                while (fast != right && fast.Next != right) // iterates until the fast pointer reaches the right node
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }
                // Speed discrepacy results in the fast node reaching the end (right node), while slow points to the middle node
                // Returns middle node
                return slow;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetMiddle method {ex}");
                return null;
            }
        }

        /* Searching Algoritms */
        // Binary Search
        // Sort Array[] first
        // Compare x w/ middle element
        // If x matches with middle element, return the middle index
        // elseif x is greater than the mid element, search on right half
        // elseif x is smaller than middle element, search on left half

        public DoublyLinkedListNode<T> BinarySearch<T>(DoublyLinkedList<T> list, T value) where T : IComparable<T>
        {
            try
            {
                DoublyLinkedListNode<T> left = list.Head;
                DoublyLinkedListNode<T> right = list.Tail;

                while (left != null && right != null && left != right.Next)
                {
                    DoublyLinkedListNode<T> middle = GetMiddle(left, right);
                    if (middle.Value.GetHashCode().CompareTo(value.GetHashCode()) == 0)
                    {
                        return middle;
                    }
                    else if (middle.Value.GetHashCode().CompareTo(value.GetHashCode()) > 0)
                    {

                        left = middle.Next;
                    }
                    else
                    {
                        right = middle.Previous;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in BinarySearch method {ex}");
                return null;
            }
        }

        // Binary search for SingleLinkedList normal binary search
        // CopyTo Array, search through this array
        // ERROR HERE?
        public T SingleBinarySearch<T>(LinkedList<T> list, T value) where T : IComparable<T>
        {
            try
            {
                T[] array = new T[list.Count];
                list.CopyTo(array, 0);

                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    if (array[mid].CompareTo(value) == 0)
                    {
                        return array[mid];
                    }
                    else if (array[mid].CompareTo(value) < 0) // ERROR HERE? - '<' is the correct operand
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SingleBinarySearch method {ex}");
                return default;
            }
        }


        // Sequential Search - LinkedList
        public LinkedListNode<T> SingleSequentialSearch<T>(LinkedList<T> list, T value) where T : IComparable<T>
        {
            try
            {
                LinkedListNode<T> current = list.Head;
                int Count = list.Count;

                for (int i = 0; i < Count; i++)
                {
                    if (current.Value.CompareTo(value) == 0)
                    {
                        return current;
                    }
                    current = current.Next;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SingleSequentialSearch method {ex}");
                return null;
            }
        }

        // Sequential Search - DoublyLinkedList
        public DoublyLinkedListNode<T> SequentialSearch<T>(DoublyLinkedList<T> list, T value) where T : IComparable<T>
        {
            try
            {
                DoublyLinkedListNode<T> current = list.Head;
                int Count = list.Count;

                for (int i = 0; i < Count; i++)
                {
                    if (current.Value.CompareTo(value) == 0)
                    {
                        return current;
                    }

                    current = current.Next;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SequentialSearch method {ex}");
                return null;
            }
        }

        // Part 8: Testing ** 
        public T LinearSearchArray<T>(List<T> list, T value)
        {
            try
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].Equals(value))
                    {
                        return list[i];
                    }
                }
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LinearSearchArray method {ex}");
                return default;
            }
        }

        
        public T BinarySearchArray<T>(List<T> list, T value) where T : IComparable<T>
        {
            try
            {
                list.Sort();
                int left = 0;
                int right = list.Count - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    if (list[mid].CompareTo(value) == 0)
                    {
                        return list[mid];
                    }
                    else if (list[mid].CompareTo(value) < 0)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in BinarySearchArray method {ex}");
                return default;
            }
        }

        //StudentPart8 Testing
        public T ListTestBinarySearch<T>(List<T> list, T value) where T : IComparable
        {
            try
            {
                int left = 0;
                int right = list.Count - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid].CompareTo(value) == 0)
                    {
                        return list[mid];
                    }
                    else if (list[mid].CompareTo(value) < 0)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return default;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error in ListBinarySearch method {ex}");
                return default;
            }
        }

        // List Bubble Sort Ascending
        public void ListBubbleSortAscending<T>(List<T> list) where T : IComparable<T>
        {
            try
            {
                int count = list.Count; // Gets the number elements 
                for (int i = 0; i < count - 1; i++) // Outer loop iterates through the list
                {
                    for (int j = 0; j < count - 1 - i; j++) // Inner loop iterates to one last index position
                    {
                        if (list[j].CompareTo(list[j + 1]) > 0)
                        {
                            // Swap elements
                            T temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error ListBubbleSortAscending method {ex}");
            }
        }


    }
}
