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
    public class _LinkedList<T> where T : IComparable
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

                //create the new node
                Node<T> newNode = new Node<T>(element);

                //find the last node and store it in the temp
                tempNode = FindLast();
            
                //connect the new node to the .next of the last node
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
                //start at the header
                Node<T> activeNode = header;

                //search for the node
                Node<T> p = Find(n);

                //if the node is found
                if (p.Element != null)
                {
                    if (p.Element.Equals(n)) //node found
                    {
                        //if the found node has a next node
                        while (!activeNode.nextNode.Element.Equals(n) && !activeNode.nextNode.Equals(null))
                        {
                            activeNode = activeNode.nextNode; //select the next node
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
                //start searching at the header (start)
                Node<T> current = new Node<T>();
                current = header;

                //if there is a next node keep
                if (current.nextNode != null)
                {
                    //skip the header
                    while (current.Element == null)
                    {
                        current = current.nextNode;
                    }

                    //until the node is found keep going
                    //if there is no next there will be an exeption
                    while (!current.Element.Equals(item))
                    {
                        current = current.nextNode;
                    }
                }
                return current;
            }
            catch(Exception e)
            {
                //on an exeption return the header (not found)
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
                //start at the header
                Node<T> current = new Node<T>();
                current = header;

                //loop until the next node is null (no next)
                while (!(current.nextNode == null))
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
        /// find the first item in the Linkedlist
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> GetFirst()
        {
            try
            {
                //start at the header
                Node<T> current = new Node<T>();
                current = header;

                //if there is no next node from the header
                if (header.nextNode != null)
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
