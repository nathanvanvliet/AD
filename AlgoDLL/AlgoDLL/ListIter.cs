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
    public class ListIter<T> where T : IComparable
    {

        //begining of the linkedlist
        protected Node<T> header = new Node<T>();

        private Node<T> current;
        private Node<T> previous;
        public _LinkedList<T> theList;

        public ListIter(_LinkedList<T> list) {
            try
            {
                //fill the placeholders with the list values
                theList = list;
                current = theList.GetFirst();
                previous = null;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// go to the next node in the linklist
        /// </summary>
        public void NextLink() {
            try
            {
                //previus node = current node
                previous = current;

                //current node is next node
                current = current.nextNode;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// get the current node
        /// </summary>
        /// <returns>Node current</returns>
        public Node<T> GetCurrent() {
            try
            {
                //return the current node
                return current;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(Node<T>);
            }
        }

        /// <summary>
        /// insert before the current node
        /// </summary>
        /// <param name="theElement"></param>
        public void InsertBefore(T theElement) {
            try
            {
                Node<T> newNode = new Node<T>(theElement);

                if (previous == null)
                {
                    //cant insert before the header node
                    throw new Exception("Inserting before the header");
                }
                else
                {
                    //insert he new element before the selected element
                    newNode.nextNode = previous.nextNode;
                    previous.nextNode = newNode;
                    current = newNode;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// insert after the current node
        /// </summary>
        /// <param name="theElement"></param>
        public void InsertAfter(T theElement) {
            try
            {
                Node<T> newNode = new Node<T>(theElement);

                newNode.nextNode = current.nextNode;
                current.nextNode = newNode;
                NextLink();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// remove the current node
        /// </summary>
        public void remove() {
            try
            {
                previous.nextNode = current.nextNode;
                current = previous.nextNode;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// reset the list
        /// </summary>
        public void reset() {
            try
            {
                current = theList.GetFirst();
                previous = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// return true if the current is the last element in the list
        /// </summary>
        /// <returns></returns>
        public bool AtEnd() {
            try
            {
                return (current.nextNode == null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(bool);
            }
        }
    }
}
