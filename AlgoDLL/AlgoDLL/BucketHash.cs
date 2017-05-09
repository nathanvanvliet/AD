/*
 *      AUTEUR: Henk Lambeck
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public class BucketHash
    {
        private const int SIZE = 101;
        public ArrayList[] data;

        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= (SIZE - 1); i++)
                data[i] = new ArrayList(4);
        }

        /// <summary>
        /// Get The hash value of a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Hash(string s)
        {
            try
            {
                long tot = 0;
                //Convert the string to characters
                char[] charray = s.ToCharArray();

                //for every character add the value to the total
                for (int i = 0; i <= (s.Length - 1); i++)
                    tot += 37 * tot + (int)charray[i];

                //add the int (total modulus data length/upperbound)
                tot = tot % data.GetUpperBound(0);
                if (tot < 0)
                    tot += data.GetUpperBound(0);

                return (int)tot;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// insert the value with its hash in the collection
        /// </summary>
        /// <param name="item"></param>
        public void Insert(string item)
        {
            try
            {
                //hash the value
                int hash_value = Hash(item);

                //search if the array contains the item using the hash, if it does, add the new item to the same hash position
                data[hash_value].Add(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// If the value excists, remove it from the collection
        /// </summary>
        /// <param name="item"></param>
        public void Remove(string item)
        {
            try
            {
                int hash_value = Hash(item);

                //search the value in an array using the hash
                if (data[hash_value].Contains(item))
                    //if the item is found, remove it
                    data[hash_value].Remove(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// search for a value in the array using the has of this value.
        /// </summary>
        /// <param name="s">the value</param>
        /// <param name="arr">the array</param>
        /// <returns>true/false</returns>
        public bool InHash(string s, ArrayList[] arr)
        {
            try
            {
                //create the hash of the value you want to find
                int hval = Hash(s);

                //if the same hash is found...
                if (arr[hval].Contains(s))
                    //return true
                    return true;

                //if not, return false
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}
