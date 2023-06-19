using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value) 
        {
            Value = value;
        }

        public T Value { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }


    }
}
