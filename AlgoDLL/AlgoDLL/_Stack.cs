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
    public class _Stack<T> where T : IComparable
    {
        //create a new list to store the elements in
        private List<T> list = new List<T>();
        T fail = default(T);
        public _Stack() {

        }

        /// <summary>
        /// add a new item to the stack
        /// </summary>
        /// <param name="item"></param>
        public void push(T item)
        {
            try
            {
                //add the element to the list
                list.Add(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// return the length of the stack
        /// </summary>
        /// <returns>length of the stack</returns>
        public int getLength()
        {
            try
            {
                //return the length of the list
                return list.Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// reset the stack
        /// </summary>
        public void clear()
        {
            //redefine the list so it is empty
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
                Debug.WriteLine(e);
                return fail;
            }
        }

        /// <summary>
        /// return the newest item on the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            try
            {
                //return the last element
                return list.Last();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                return fail;
            }
        }

        /// <summary>
        /// return all items in the Stack
        /// </summary>
        public void loop()
        {
            try
            {
                //loop for all elements in the list
                for (int i = 0; i < (list.Count - 1); i++)
                {
                    // write all information of the element to the debugger
                    Debug.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
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
            try
            {
                //return the index value of the element in the list
                return list[index];
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return fail;
            }
        }
    }
}
