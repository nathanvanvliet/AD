/*
 *      AUTEUR: Nathan van Vliet 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class Search<T> where T : IComparable
    {
        /// <summary>
        /// Finds the last occurance of given search value in the given array
        /// </summary>
        /// <param name="arr"> the array to be searched</param>
        /// <param name="searchValue">the value to be searched for</param>
        /// <returns>the index number of the last occurance in the array, -1 if value is not in the array</returns>
        public static int lastSeqSearch(T[] arr, T searchValue)
        {
            try
            {
                // default position is -1 for when the searchvalue isn't found
                int position = -1;
                int length = arr.Length;
                // check if any item in the array equals the searchvalue
                for (int i = 0; i < length; i++)
                {
                    if (arr[i].Equals(searchValue))
                    {
                        // if it does, return the position
                        position = i;
                    }
                }
                // otherwise, return default -1
                return position;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(int);
            }
        }


        /// <summary>
        /// Finds the first occurance of given search value in the given array
        /// </summary>
        /// <param name="arr"> the array to be searched</param>
        /// <param name="searchValue"> the value to be searched for </param>
        /// <returns>the index number of the first occurance in the array, -1 if the value is not in the array</returns>
        public static int firstSeqSearch(T[] arr, T searchValue)
        {
            try
            {
                // keeps track of iterations
                int compCount = 0;
                // default position is -1 for when the searchvalue isn't found
                int position = -1;
                int length = arr.Length;
                // found = 0, if found is 1, stop searching. 
                int found = 0;
                // check if any item in the array equals the searchvalue
                for (int i = 0; i < length && found != 1; i++)
                {
                    compCount++;
                    if (arr[i].Equals(searchValue))
                    {
                        // if it does, return the position
                        position = i;
                        // set found to 1 to stop the search
                        found = 1;
                        // write amount of iterations to the console
                        Console.WriteLine("it took sequential search {0} iterations to complete the search", compCount);
                    }
                }
                // otherwise, return default -1
                return position;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(int);
            }
        }

        /// <summary>
        /// Finds the given search value in the given array at the given occurance 
        /// </summary>
        /// <param name="arr"> the array to be searched</param>
        /// <param name="searchValue"> the value to be searched for </param>
        /// <param name="occ">the occurance to be returned</param>
        /// <returns>the index number of the last occurance in the array</returns>
        public static int occuranceSeqSearch(T[] arr, T searchValue, int occ)
        {
            try
            {
                // stores the occurance 
                int o = 1;
                // default position is -1 for when the searchvalue isn't found
                int position = -1;
                int length = arr.Length;
                //found = 0, if found is 1, stop searching. 
                int found = 0;
                // check if any item in the array equals the searchvalue
                for (int i = 0; i < length && found != 1; i++)
                {
                    if (arr[i].Equals(searchValue))
                    {
                        // check if the found value is the occurance we wish to find
                        if (o == occ)
                        {
                            // if it is, return the position
                            position = i;
                            // set found to 1 to stop the search
                            found = 1;
                        }
                        else
                        {
                            // if it isn't the occurance we wish to find, o = o+1, search continues 
                            o++;
                        }
                    }
                }
                // if value isn't found, return default -1
                return position;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(int);
            }
        }

        /// <summary>
        /// Finds the minimum value in the given array
        /// </summary>
        /// <param name="arr">the array to be searched</param>
        /// <returns>the minimum value in the array</returns>
        public static T FindMin(T[] arr)
        {
            try
            {
                // start value of min  = first item in the array
                T min = arr[0];
                int length = arr.Length;
                // check all items, if item is lower than min, replace min with lowest value
                for (int i = 0; i < length - 1; i++)
                    if (arr[i].CompareTo(min) < 0)
                    {
                        min = arr[i];
                    }
                // return lowest value
                return min;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(T);
            }
        }

        /// <summary>
        /// finds the maximum value in the array
        /// </summary>
        /// <param name="arr"> array to be searched </param>
        /// <returns> the maximum value in the array</returns>
        public static T FindMax(T[] arr)
        {
            try
            {
                // start value of max  = first item in the array
                T max = arr[0];
                int length = arr.Length;
                // check all items, if item is higher than max, replace max with highest value
                for (int i = 0; i < length - 1; i++)
                    if (arr[i].CompareTo(max) > 0)
                    {
                        max = arr[i];
                    }
                // return highest value
                return max;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(T);
            }
        }

        /// <summary>
        /// Binary search, finds the index of the given value in the given array
        /// NOTE: binary search only works on ordered arrays.
        /// </summary>
        /// <param name="arr">the array to be searched</param>
        /// <param name="searchValue">the value to be searched for </param>
        /// <returns>index of the found value, -1 if array doesn't contain the value</returns>
        public static int binarySearch(T[] arr, T searchValue)
        {
            try
            {
                int min, max, middle, compCount;
                // compcount keeps track of iterations
                compCount = 0;
                min = 0;
                max = arr.Length -1 ;
                // as long as min is smaller than max, keep searching 
                while (min <= max)
                {
                    compCount++;
                    // get the middle of the array
                    middle = (int)Math.Round((min + max) / 2.0, MidpointRounding.ToEven);

                    // if the seachvalue is the middle of the array, return the middle -1 to receive index number
                    if (searchValue.CompareTo(arr[middle]) == 0)
                    {
                        Console.WriteLine("it took Binary search {0} iterations to complete the search", compCount);
                        return middle;
                    }
                    // if the searchvalue is lower than the middle, set max to the middle, search half the array again
                    else if (searchValue.CompareTo(arr[middle]) < 0)
                    {
                        max = middle - 1;
                    }
                    // if the searchvalue is higher than the middle, set min to the middle, search half the array again
                    else if (searchValue.CompareTo(arr[middle]) > 0)
                    {
                        min = middle + 1;
                    }
                }

                // return -1 if value was not found 
                return -1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return default(int);
            }
        }          
    }
}

