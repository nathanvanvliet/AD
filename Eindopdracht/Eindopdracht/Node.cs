using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class Node<T> where T : IComparable
    {
        public T Element;
        public Node<T> nextNode;
        public Node<T> previousNode;

        public Node()
        {
            Element = default(T);
            nextNode = null;
            previousNode = null;
        }

        public Node(T Element)
        {
            this.Element = Element;
            nextNode = null;
            previousNode = null;
        }
    }
}
