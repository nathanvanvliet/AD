using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class _LinkedList<T> where T : IComparable
    {
        //begining of the linkedlist
        protected Node<T> header = new Node<T>();


        public _LinkedList()
        {
        }

        /// <summary>
        /// Add an item to the linkedlist
        /// </summary>
        /// <param name="element"></param>
        /// <param name="after"></param>
        public void Insert(T element)
        {
            Node<T> tempNode = new Node<T>();
            Node<T> newNode = new Node<T>(element);

            tempNode = FindLast();
            
            tempNode.nextNode = newNode;
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n"></param>
        public void Remove(T n)
        {
            Node<T> activeNode = header;
            Node<T> p = Find(n);

            int counterTotal = 0;

            //loop and count elements in linkedList
            while (!(activeNode.nextNode == null))
            {
                counterTotal++;
                activeNode = activeNode.nextNode;
            }

            //reset activeNode
            activeNode = header;
            int counter = 0;

            while (!(activeNode.nextNode.Equals(n)) && ((counter + 1) != counterTotal))
            {
                activeNode = activeNode.nextNode;
                counter++;
            }

            //if the element after the removed element not is null, assign it.
            if (activeNode.nextNode.nextNode != null)
            {
                activeNode.nextNode = activeNode.nextNode.nextNode;
                activeNode.nextNode.nextNode = null;
            }
        }

        /// <summary>
        /// find an item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Node<T> Find(T item)
        {
            Node<T> current = new Node<T>();
            current = header;
            while (!current.Element.Equals(item))
            {
                current = current.nextNode;
            }
            return current;
        }

        /// <summary>
        /// find the last item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Node<T> FindLast()
        {
            Node<T> current = new Node<T>();
            current = header;
            while (!(current.nextNode == null))
            {
                current = current.nextNode;
            }
            return current;
        }

        /// <summary>
        /// find the first item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> GetFirst()
        {
            Node<T> current = new Node<T>();
            current = header;
            if (header.nextNode != null)
            {
                return header.nextNode;
            }
            else {
                return header;
            }
        }
    }
}
