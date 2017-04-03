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
            if(after == null)
            {
                tempNode = header;
            }
            else
            {
                tempNode = Find(after);
            }
          

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

            if (!(p.nextNode == null || p.previousNode == null))
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
        public Node<T> Find(T item) {
            Node<T> current = new Node<T>();
            current = header;
            try
            {
                if (current.nextNode != null)
                {
                    while (current.Element == null)
                    {
                        current = current.nextNode;
                    }

                    while (!current.Element.Equals(item))
                    {
                        current = current.nextNode;
                    }
                }
                return current;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return header;
            }
        }

        /// <summary>
        /// find the last item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> FindLast()
        {
            Node<T> current = new Node<T>();
            current = header;
            while (!(current.nextNode == null))
            {
                current = current.nextNode;
            }
            return current;
        }

        public Node<T> GetFirst()
        {
            Node<T> current = new Node<T>();
            current = header;
            if (header.nextNode != null)
            {
                return header.nextNode;
            }
            else
            {
                return header;
            }
        }

    }
}
