/*
 *      AUTEUR: Nathan van Vliet 
 *      SOURCE: McMillan, M. (2007). Data Structures and Algorithms Using C#. Cambridge, Groot-Brittannië: Cambridge University Press
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgoDLL
{
    public class MyArrayList<T> : IEnumerable
    {
        // the index variable keeps track of the array size, making it resizeable
        private int index = 0;
        // the array to add arraylist functionality to, starting at size 0
        private T[] array = new T[0];

        /// <summary>
        /// add a value to the array
        /// </summary>
        /// <param name="value to add"></param>
        public void Add(T value)
        {
            try
            {
                // if the index is the same as the arraylength, resize the array
                if (index == array.Length)
                {
                    sizeUpArray();
                }
                // if there is room in the array, add given value to the empty index number
                if (index < array.Length)
                {
                    array[index] = value;
                    // size up array with 1 
                    index++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// removes a value at given index number 
        /// </summary>
        /// <param name="index number to remove value from"></param>
        public void removeAt(int index)
        {
            try
            {
                // create a temporary list out of the array
                List<T> temp = new List<T>(array);
                // remove item at given index number
                temp.RemoveAt(index);
                // change list back to array
                array = temp.ToArray();
                // size array down with 1
                index--;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }


        /// <summary>
        /// remove given value from the arraylist
        /// </summary>
        /// <param name="value to remove"></param>
        public void remove(T value)
        {
            try
            {
                // create a temporary list out of the array
                List<T> temp = new List<T>(array);
                // remove item with given value
                temp.Remove(value);
                // change list back to array
                array = temp.ToArray();
                // size array down with 1
                index--;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// adds a range of items to the arraylist 
        /// </summary>
        /// <param name="Icollection of values to add"></param>
        public void addRange(ICollection values)
        {
            try
            {
                // count the amount of items in the icollection list
                int c = values.Count;
                // create space in the array to add the list
                for (int i = 0; i < c; i++)
                {
                    sizeUpArray();
                }
                if (index < array.Length)
                {
                    // copy range to array at new index nr
                    values.CopyTo(array, index);
                    // size the array up 
                    index += c;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// returns the length of the array
        /// </summary>
        /// <returns> the array length </returns>
        public int Count()
        {
            try
            {
                //return the length of the array
                return array.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// get item at given index
        /// </summary>
        /// <param name="index to get item from"></param>
        /// <returns>the item at the given index</returns>
        public T getIndex(int index)
        {
            try
            {
                // temp variable to store given index item 
                T toGet = array[index];
                // return item
                return toGet;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(T);
            }
        }


        /// <summary>
        /// clears the array, removes all items from the array
        /// </summary>
        public void clear()
        {
            try
            {
                // set index back to zero
                index = 0;
                // resize the array back to zero
                Array.Resize(ref array, 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// returns the array capacity
        /// </summary>
        /// <returns> the capacity of the array</returns>
        public int Capacity()
        {
            try
            {
                //return the capacity of the array
                return array.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default(int);
            }
        }


        /// <summary>
        ///  check if the array contains given item
        /// </summary>
        /// <param name="item to check"></param>
        /// <returns>true if array contains the given item, false if it doesn't</returns>
        public bool contains(T item)
        {
            try
            {
                // check all items in the array to see if array contains given item
                foreach (T value in array)
                {
                    if (value.Equals(item))
                    {
                        // if yes, return true
                        return true;
                    }
                }
                // if no, return false
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(bool);
            }
        }

        /// <summary>
        /// copies the arraylist to a new array, returns the new array
        /// </summary>
        /// <param name="newArray to copy the arraylist to"></param>
        /// <returns> new array </returns>
        public T[] CopyTo(T[] newArray)
        {
            try
            {
                //create a copy of the array
                newArray = array;

                //return the copy
                return newArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default(T[]);
            }
        }


        /// <summary>
        /// get the index number of given item
        /// </summary>
        /// <param name="item to find index of"></param>
        /// <returns>index of given item, or -1 if item is not in the array </returns>
        public int indexOf(T item)
        {
            try
            {
                // get the array length
                int l = array.Length;
                // loop through array to find given item
                for (int i = 0; i < l; i++)
                {
                    if (array[i].Equals(item))
                    {
                        // if item is found, return the index number
                        return i;
                    }
                }
                // if item is not found, return -1
                return -1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(int);
            }
        }

        /// <summary>
        /// size the array up by 1
        /// </summary>
        public void sizeUpArray()
        {
            try
            {
                //resize the array to size+1
                Array.Resize(ref array, array.Length + 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// automatically cast the IEnumerable so you can use it in loops
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MyEnum<T> GetEnumerator()
        {
            try
            {
                //return the array as a IEnumerable object
                return new MyEnum<T>(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default(MyEnum<T>);
            }
        }


    }

    /// <summary>
    /// enum class for the IEnumerator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyEnum<T> : IEnumerator
    {

        public T[] array;

        // Enumerators are positioned before the first element 
        // until the first MoveNext() call. 
        int position = -1;

        public MyEnum(T[] list)
        {
            array = list;
        }

        /// <summary>
        /// go to the next item in the array
        /// </summary>
        /// <returns>if the array position is valid</returns>
        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        /// <summary>
        /// set the active position to the start
        /// </summary>
        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        /// <summary>
        /// return the current element
        /// </summary>
        public T Current
        {
            get
            {
                try
                {
                    return array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

