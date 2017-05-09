/*
 *      AUTEUR: Nathan van Vliet
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class pqItem<T> where T : IComparable
    {
        public int priority = 0;
        public T value;
       
        public pqItem(T value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }

    public class _PriorityQueue<T> where T : IComparable
    {
        private List<pqItem<T>> list = new List<pqItem<T>>();
        T fail = default(T);
        public _PriorityQueue()
        {

        }

        /// <summary>
        /// add a new item to the queue (start)
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item, int priority)
        {
            try
            {
                //add the item to the list
                list.Insert(0, new pqItem<T>(item, priority));

                //order the list for priority
                list.Sort((x, y) =>
                        x.priority.CompareTo(y.priority));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// return the length of the queue
        /// </summary>
        /// <returns>length of the queue</returns>
        public int Count()
        {
            try
            {
                return list.Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// reset the queue
        /// </summary>
        public void clear()
        {
            list = new List<pqItem<T>>();
        }

        /// <summary>
        /// remove the newest item from the queue (first)
        /// </summary>
        /// <returns></returns>
        public T deQueue()
        {
            try
            {
                //Load the newest item
                T item = list.First().value;

                //remove last item from the list
                list.Remove(list.First());

                //return removed item
                return item;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                return fail; 
            }
        }

        /// <summary>
        /// return the newest item on the queue
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            try
            {
                return list.First().value;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return fail;
            }
        }

        /// <summary>
        /// return all items in the queue
        /// </summary>
        public void loop()
        {
            try
            {
                for (int i = 0; i < (list.Count - 1); i++)
                {
                    Debug.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }
        /// <summary>
        /// This method is only created to be able to get the content of the Pqueue 
        /// to print it to the listbox 
        /// </summary>
        /// <param name="index"> the index number to get the item of</param>
        /// <returns>the item at the given index number</returns>
        public T getIndex(int index)
        {
            try
            {
                pqItem<T> temp = list[index];
                return temp.value;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(T);
            }
            
        }
    }
}
