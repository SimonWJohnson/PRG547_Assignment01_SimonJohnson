using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedListNode<T> Head
        {
            get;
            private set;
        }

        public DoublyLinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public void AddFirst(T value) 
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }

        public void AddFirst(DoublyLinkedListNode<T> node) 
        {
            // Save off the Head node so we do't lose it
            DoublyLinkedListNode<T> temp = Head;

            // Point head to the new node
            Head = node;
            Head.Next = temp;

            if (Count == 0)
            {
                // If the list is empty then Head and Tail should point to the new node
                Tail = Head;
            }
            else 
            {
                temp.Previous = Head;
            }

            Count++;
        }

        public void AddLast(T value) 
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }

        public void AddLast(DoublyLinkedListNode<T> node) 
        {
            if (Count == 0)
            {
                Head = node;
            }
            else 
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }

        public void RemoveFirst() 
        {
            if (Count != 0)
            {
                Head = Head.Next;

                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
                else 
                {
                    Head.Previous = null;
                }
            }
        }


        public void RemoveLast() 
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else 
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        public int Count 
        {
            get;
            private set;
        }

        public void Add(T item) 
        {
            AddFirst(item);
        }

        public bool Contains(T item) 
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item)) 
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get 
            {
                return false;
            }
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null) // It's a node in the middle or end
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else 
                    {
                        RemoveFirst();
                    }
                    return true;
                }

                previous = current;
                current = current.Next;

            }

            return false;
        }

        //public IEnumerator<T> GetEnumerator() // May need to be reverted back to OG version
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        
    }
}
