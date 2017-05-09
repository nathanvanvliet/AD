using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public static class Sort
    {
        /// <summary>
        ///     Sorts the Array using a Selection sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns>The amount of ticks to completion</returns>
        public static long Selection<T>(this T[] arr) where T : IComparable<T>
        {
            TimeModule watch = new TimeModule(); //creat a timemodule to keep record of the time

            try
            {
                int arrLength = arr.Length;
                //start looping the sorter
                //pos_min is short for position of min
                int pos_min;

                //start the timemodule
                watch.start();


                for (int i = 0; i < arrLength - 1; i++)
                {
                    pos_min = i; //set pos_min to the current index of array

                    for (int j = i + 1; j < arrLength; j++)
                    {
                        // We now use 'CompareTo' instead of '<'
                        if (arr[j].CompareTo(arr[pos_min]) < 0)
                        {
                            //pos_min will keep track of the index that min is in, this is needed when a swap happens
                            pos_min = j;
                        }
                    }

                    //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                    if (pos_min != i)
                    {
                        T temp = arr[i];
                        arr[i] = arr[pos_min];
                        arr[pos_min] = temp;
                    }
                }

                //log the result
                watch.stop();

                //return the ticks
                return watch.elapseTime();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     Sorts the Array using a Bubblesort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns>The amount of ticks to completion</returns>
        public static long Bubble<T>(this T[] arr) where T : IComparable<T>
        {
            TimeModule watch = new TimeModule(); //creat a timemodule to keep record of the time

            try
            {
                T[] checkArray = arr;
                int arrLength = arr.Length;
                Boolean done = false;

                //start the timemodule
                watch.start();

                while (!done)
                {
                    for (var i = 1; i < arrLength; i++)
                    {
                        for (var j = 0; j < arrLength - i; j++)
                        {
                            if (arr[j].CompareTo(arr[j + 1]) > 0)
                            {
                                T temp = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = temp;
                            }
                        }
                    }

                    //check if the sorting changed anything
                    if (arr.SequenceEqual(checkArray))    //the sorting didnt change (its done!)
                    {
                        done = true;
                        //stop timer
                        watch.stop();
                    }
                    else
                    {
                        //the sorting did change (its not yet done)
                        checkArray = arr;
                    }
                }








                /*
                //loop through the array until there are no changes
                for (int i = 0; i < arrLength && !done; i++)
                {
                    // set done to false everytime the loop starts again
                    done = false;
                    for (int j = 0; j < arrLength - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            //Swap the 2 values
                            T t = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = t;

                            //if the array has been changed set the done flag to true so it executes again
                            done = true;
                        }
                        //if thefre are no changes the flag will be false and stop the loop
                    }
                }

                //log the result
                watch.stop();
                */

                //return the ticks
                return watch.elapseTime();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     Sort the array using an Insertion Algoritm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns>The elapsed time in ticks</returns>
        public static long Insertion<T>(this T[] arr) where T : IComparable<T>
        {
            int i, j;
            TimeModule watch = new TimeModule();    //creat a timemodule to keep record of the time


            try
            {
                int arrLength = arr.Length;         //Length of the array

                //start the timemodule
                watch.start();

                for (i = 1; i < arrLength; i++)
                {
                    T value = arr[i];
                    j = i - 1;
                    while ((j >= 0) && (arr[j].CompareTo(value) > 0))
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = value;
                }

                //log the result
                watch.stop();

                //return the ticks
                return watch.elapseTime();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
