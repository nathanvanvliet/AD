/*
 *      AUTEUR: Henk Lambeck
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class _DoublyLinkedList<T> where T : IComparable
    {
        //begining of the linkedlist
        protected Node<T> header = new Node<T>();

        
        public _DoublyLinkedList() {
        }

        /// <summary>
        /// Add an item to the linkedlist
        /// </summary>
        /// <param name="element">the new element</param>
        /// <param name="after">after which the new element must be placed</param>
        public void Insert(T element, T after) {
            try
            {
                Node<T> previousNode = new Node<T>();
                Node<T> newNode = new Node<T>(element);

                //if the after is empty
                if(after == null)
                {
                    //insert after the header
                    previousNode = header;

                    //setup the previousnode (header)
                    previousNode.nextNode = newNode;
                    previousNode.previousNode = newNode;

                    //setup the new node
                    newNode.nextNode = previousNode;
                    newNode.previousNode = previousNode;
                }
                else
                {
                    //insert after the "after"
                    previousNode = Find(after);

                    //setup the previousnode (header)
                    previousNode.nextNode = newNode;

                    //setup the new node
                    newNode.nextNode = header;
                    newNode.previousNode = previousNode;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// remove a item from the Linkedlist
        /// </summary>
        /// <param name="n">the element to be removed</param>
        public void Remove(T n) {
            try
            {
                Node<T> p = Find(n);
                
                //can't delete the header. 
                if (!(p.nextNode == null || p.previousNode == null) && (p != header))
                {
                    //set the next node of the previous node to the next node of the current node
                    p.previousNode.nextNode = p.nextNode;
                    //set the previous node of the next node to the previous node of the current node
                    p.nextNode.previousNode = p.previousNode;

                    //unlink the current node
                    //garbage collection will delete this object after a while
                    p.nextNode = null;
                    p.previousNode = null;
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
        /// <param name="item">the element to search for</param>
        /// <returns>the element which was found (or the last)</returns>
        public Node<T> Find(T item) {
            Node<T> current = new Node<T>();
            current = header;
            try
            {
                //if there is  only a header, dont loop just return the header, otherwise there is an infinite loop
                if ((current.nextNode != null) )
                {
                    //skip the header at the start
                    while (current.Element == null)
                    {
                        current = current.nextNode;
                    }

                    //loop through all elements until you find the element you look for, or stop at the last element. (no infinite loop)
                    while (!(current.Element.Equals(item)) && (current.nextNode != header))
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
        /// <returns>The last node</returns>
        public Node<T> FindLast()
        {
            Node<T> current = new Node<T>();
            current = header;

            //loop until the next element is the header, or null (which means the header is the only element)
            while (!(current.nextNode == null) && !(current.nextNode == header))
            {
                //the current node is the next node
                current = current.nextNode;
            }
            return current;
        }

        /// <summary>
        /// returns the first element in the Link
        /// </summary>
        /// <returns>the first Node</returns>
        public Node<T> GetFirst()
        {
            Node<T> current = new Node<T>();
            current = header; //start at the header node

            //is there only the header?
            if (header.nextNode != null)
            {
                //no, select next node (first)
                return header.nextNode;
            }
            else
            {
                //yes, so the header is the first element
                return header;
            }
        }

    }
}
