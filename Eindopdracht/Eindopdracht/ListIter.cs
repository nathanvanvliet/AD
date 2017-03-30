using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class ListIter<T> where T : IComparable
    {

        //begining of the linkedlist
        protected Node<T> header = new Node<T>();

        private Node<T> current;
        private Node<T> previous;
        public _LinkedList<T> theList;

        public ListIter(_LinkedList<T> list) {
            try
            {
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
                previous = current;
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
                return current;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// insert before the current node
        /// </summary>
        /// <param name="theElement"></param>
        public void InsertBefore(T theElement) {
            Node<T> newNode = new Node<T>(theElement);

            if (current.previousNode == null)
            {
                throw new Exception("Inserting before the header");
            }
            else {
                newNode.nextNode = previous.nextNode;
                previous.nextNode = newNode;
                current = newNode;
            }
        }

        /// <summary>
        /// insert after the current node
        /// </summary>
        /// <param name="theElement"></param>
        public void InsertAfter(T theElement) {
            Node<T> newNode = new Node<T>(theElement);

            newNode.nextNode = current.nextNode;
            current.nextNode = newNode;
            NextLink();
        }

        /// <summary>
        /// remove the current node
        /// </summary>
        public void remove() {
            previous.nextNode = current.nextNode;
        }

        /// <summary>
        /// reset the list
        /// </summary>
        public void reset() {
            current = theList.GetFirst();
            previous = null;
        }

        /// <summary>
        /// return true if the current is the last element in the list
        /// </summary>
        /// <returns></returns>
        public bool AtEnd() {
            return (current.nextNode == null);
        }
    }
}
