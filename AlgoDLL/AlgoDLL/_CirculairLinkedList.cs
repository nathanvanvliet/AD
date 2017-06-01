/*
 *      AUTEUR: Henk Lambeck
 *      SOURCE: McMillan, M. (2007). Data Structures and Algorithms Using C#. Cambridge, Groot-Brittannië: Cambridge University Press
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class _CirculairLinkedList<T>  where T  : IComparable
    {
        //begining of the linkedlist
        protected Node<T> header = new Node<T>();


        public _CirculairLinkedList()
        {
        }

        /// <summary>
        /// Add an item to the linkedlist
        /// </summary>
        /// <param name="element">The new element</param>
        /// <param name="after">the target where the new must be placed after</param>
        public void Insert(T element, T after)
        {
            try
            {
                Node<T> tempNode = new Node<T>();
                Node<T> newNode = new Node<T>(element);

                //search for and store the node in a temp
                tempNode = Find(after);

                //switch the node references
                newNode.nextNode = tempNode.nextNode;
                newNode.previousNode = tempNode;
                tempNode.nextNode = newNode;

                //set the next of the last element to the header
                FindLast().nextNode = header;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n">the target Node</param>
        public void Remove(T n)
        {
            try
            {
                Node<T> p = Find(n);

                if (!(p.nextNode == null))
                {
                    //set the next of the previous node to the nextnode
                    p.previousNode.nextNode = p.nextNode;

                    //set the previous node of the next node to the previous node
                    p.nextNode.previousNode = p.previousNode;

                    //set next and previous of the current node to null
                    p.nextNode = null;
                    p.previousNode = null;
                }

                //if the last node is the header (no other nodes)
                if(FindLast().Equals(header))
                {
                    // reset header
                    header.nextNode = null;
                    header.previousNode = null;
                    header.Element = default(T);
                }
                //if not
                else
                {
                    //set the next of the last node to the header
                    FindLast().nextNode = header;
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
        /// <param name="item">The target node</param>
        /// <returns>The node which was found, or the last</returns>
        public Node<T> Find(T item)
        {
            try
            {
                Node<T> current = new Node<T>();

                //start at the header
                current = header;

                //check if there is only the header
                if (current.nextNode != null)
                {
                    //skip the header
                    while (current.Element == null)
                    {
                        current = current.nextNode;
                    }
                     //search for the item until you reach the last
                    while (!current.Element.Equals(item) && current.nextNode != header)
                    {
                        //not found, next node
                        current = current.nextNode;
                    }
                }

                //return the found node, or return the last node
                return current;
                
                //the final check happens outside the method (the compare)
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return header;
            }
        }

        /// <summary>
        /// find the last item in the Linkedlist
        /// </summary>
        /// <returns>The last Node</returns>
        public Node<T> FindLast()
        {
            try
            {
                Node<T> current = new Node<T>();
                current = header;

                 //check if next node is header, if not go to next
                 while (!(current.nextNode == null || current.nextNode == header))
                 {
                         current = current.nextNode;
                 }

                 //return the last node
                 return current;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return header;
            }
        }

        /// <summary>
        /// Returns the first node in the linkedList
        /// </summary>
        /// <returns>The first Node</returns>
        public Node<T> GetFirst()
        {
            try
            {
                Node<T> current = new Node<T>();
                current = header;

                //if the header has a next node
                if (header.nextNode != null && current.nextNode != header)
                {
                    //return the first node
                    return header.nextNode;
                }
                else
                {
                    //return the header
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
