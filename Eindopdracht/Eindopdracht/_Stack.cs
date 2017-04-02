using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class _Stack<T> where T : IComparable
    {
        private List<T> list = new List<T>();

        public _Stack() {

        }

        /// <summary>
        /// add a new item to the stack
        /// </summary>
        /// <param name="item"></param>
        public void push(T item)
        {
            list.Add(item);
        }

        /// <summary>
        /// return the length of the stack
        /// </summary>
        /// <returns>length of the stack</returns>
        public int getLength()
        {
            return list.Count;
        }

        /// <summary>
        /// reset the stack
        /// </summary>
        public void clear()
        {
            list = new List<T>();
        }

        /// <summary>
        /// remove the newest item from the stack (last)
        /// </summary>
        /// <returns></returns>
        public T pop()
        {
            try
            {
                //Load the last item
                T item = list.Last();

                //remove last item from the list
                list.Remove(list.Last());

                //return removed item
                return item;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// return the newest item on the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return list.Last();
        }

        /// <summary>
        /// return all items in the Stack
        /// </summary>
        public void loop()
        {
            for (int i = 0; i < (list.Count - 1); i++)
            {
                Console.WriteLine(list[i]);
            }
        }


        /// <summary>
        /// This method is only created to be able to get the content of the stack 
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
