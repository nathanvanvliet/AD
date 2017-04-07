﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class _Queue<T> where T : IComparable
    {
        private List<T> list = new List<T>();
        T fail = default(T);
        public _Queue() {

        }

        /// <summary>
        /// add a new item to the queue (start)
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item)
        {
            try
            {
                list.Insert(0, item);
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
            return list.Count;
        }

        /// <summary>
        /// reset the queue
        /// </summary>
        public void clear()
        {
            list = new List<T>();
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
                T item = list.Last();

                //remove last item from the list
                list.Remove(list.Last());

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
                return list.First();
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
            for (int i = 0; i < (list.Count - 1); i++)
            {
                Debug.WriteLine(list[i]);
            }
        }

        /// <summary>
        /// This method is only created to be able to get the content of the queue 
        /// to print it to the listbox 
        /// </summary>
        /// <param name="index"> the index number to get the item of</param>
        /// <returns>the item at the given index number</returns>
        public T getIndex(int index)
        {
            return list[index];
        }
    }
}
