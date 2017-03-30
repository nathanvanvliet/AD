﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class _CirculairLinkedList<T>  where T  : IComparable
    {
        //begining of the linkedlist
        protected Node<T> header = new Node<T>();


        public _CirculairLinkedList()
        {
        }

        /// <summary>
        /// Add an item to the linkedlist
        /// </summary>
        /// <param name="element"></param>
        /// <param name="after"></param>
        public void Insert(T element, T after)
        {
            Node<T> tempNode = new Node<T>();
            Node<T> newNode = new Node<T>(element);

            tempNode = Find(after);

            newNode.nextNode = tempNode.nextNode;
            newNode.previousNode = tempNode;
            tempNode.nextNode = newNode;

            //set the next of the last element to the header
            FindLast().nextNode = header;
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n"></param>
        public void Remove(T n)
        {
            Node<T> p = Find(n);

            if (!(p.nextNode == null))
            {
                p.previousNode.nextNode = p.nextNode;
                p.nextNode.previousNode = p.previousNode;

                p.nextNode = null;
                p.previousNode = null;
            }

            //set the next of the last element to the header
            FindLast().nextNode = header;
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
            while (!(current.Element.Equals(item)) && (current.nextNode != header))
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
            while (!(current.nextNode == header))
            {
                current = current.nextNode;
            }
            return current;
        }
    }
}
