using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    class Node<T>
    {
        public int Id { get; set; }
        public Node<T>? pNext;
        public T Value { get; set; }


        public Node(T value, Node<T>? pNext = null)
        {
            this.pNext = pNext;
            Value = value;
        }
    }
}
