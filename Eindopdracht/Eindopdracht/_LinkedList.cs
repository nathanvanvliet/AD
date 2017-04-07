using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                Node<T> tempNode = new Node<T>();
                Node<T> newNode = new Node<T>(element);

                tempNode = FindLast();
            
                tempNode.nextNode = newNode;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n"></param>
        public void Remove(T n)
        {
            try
            {
                Node<T> activeNode = header;
                Node<T> p = Find(n);
                if (p.Element != null)
                {
                    if (p.Element.Equals(n))
                    {
                        while (!activeNode.nextNode.Element.Equals(n) && !activeNode.nextNode.Equals(null))
                        {
                            activeNode = activeNode.nextNode;
                        }
                        //temp var to keep the new next node
                        Node<T> temp = activeNode.nextNode.nextNode;

                        //clear the old next node
                        activeNode.nextNode.nextNode = null;

                        //set the new next node
                        activeNode.nextNode = temp;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// find an item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> Find(T item)
        {
            try
            {
                Node<T> current = new Node<T>();
                current = header;
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
            try
            {
                Node<T> current = new Node<T>();
                current = header;
                while (!(current.nextNode == null))
                {
                    current = current.nextNode;
                }
                return current;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return header;
            }
            
        }

        /// <summary>
        /// find the first item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> GetFirst()
        {
            try
            {
                Node<T> current = new Node<T>();
                current = header;
                if (header.nextNode != null)
                {
                    return header.nextNode;
                }else
                {
                    return header;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return header;
            }
            
        }
    }
}
