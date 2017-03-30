using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class _DoublyLinkedList<T> where T : IComparable
    {
        //begining of the linkedlist
        protected Node<T> header = new Node<T>();

        
        public _DoublyLinkedList() {
        }

        /// <summary>
        /// Add an item to the linkedlist
        /// </summary>
        /// <param name="element"></param>
        /// <param name="after"></param>
        public void Insert(T element, T after) {
            Node<T> tempNode = new Node<T>();
            Node<T> newNode = new Node<T>(element);

            tempNode = Find(after);

            newNode.nextNode = tempNode.nextNode;
            newNode.previousNode = tempNode;
            tempNode.nextNode = newNode;
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n"></param>
        public void Remove(T n) {
            Node<T> p = Find(n);

            if (!(p.nextNode == null))
            {
                p.previousNode.nextNode = p.nextNode;
                p.nextNode.previousNode = p.previousNode;

                p.nextNode = null;
                p.previousNode = null;
            }
        }

        /// <summary>
        /// find an item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Node<T> Find(T item) {
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
    }
}
