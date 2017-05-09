/*
 *      AUTEUR: Henk Lambeck
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class Node<T> where T : IComparable
    {
        //current value in the node
        public T Element;

        //reference to the next node
        public Node<T> nextNode;
        //reference to the previous node
        public Node<T> previousNode;

        public Node()
        {
            //creat the new node and fill it with a default value and empty references
            Element = default(T);
            nextNode = null;
            previousNode = null;
        }

        public Node(T Element)
        {
            //creat the new node and fill it with the element and empty references
            this.Element = Element;
            nextNode = null;
            previousNode = null;
        }
    }
}
