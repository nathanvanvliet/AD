﻿/*
 *      AUTEUR: Henk Lambeck
 *      SOURCE: McMillan, M. (2007). Data Structures and Algorithms Using C#. Cambridge, Groot-Brittannië: Cambridge University Press 
 *            + http://academic.regis.edu/dbahr/generalpages/datastructures/datastrucpart11.pdf Page 15
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDLL
{
    public static class Hash
    {
        /// <summary>
        /// make a super simple hash for the given value(s)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="arr"></param>
        /// <returns>hash value</returns>
        public static int SimpleHash(string s, string[] arr) {
            try
            {
                int tot = 0;

                //Convert the string to characters
                char[] cname = s.ToCharArray();

                //for every character add the value to the total
                for (int i = 0; i <= cname.GetUpperBound(0); i++)
                    tot += (int)cname[i];

                //return the int (total modulus arr length/upperbound)
                return tot % arr.GetUpperBound(0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// make a better hash for the given value(s)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="arr"></param>
        /// <returns>hash value</returns>
        public static int BetterHash(string s, string[] arr)
        {
            try
            {
                long tot = 0;
                char[] cname;
                cname = s.ToCharArray();

                for (int i = 0; i <= cname.GetUpperBound(0); i++)
                    tot += 37 * tot + (int)cname[i]; // *37, this has to do with it being prime so it helps with collisions + Covers all the letters, numbers, and a space. + Making as large or larger than the alphabet helps avoid collisions.  

                tot = tot % arr.GetUpperBound(0); //total modulus arr length/upperbound
                if (tot < 0) //if the total is smaller as 0
                    tot += arr.GetUpperBound(0); //ass the total length of the array to the total

                return (int)tot;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(int);
            }
        }

        /// <summary>
        /// print all values and there hash in the debugger
        /// </summary>
        /// <param name="arr"></param>
        public static void ShowDistrib(string[] arr) {
            try
            {
                //loop through all array items
                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    if (arr[i] != null) //if not empty/null
                        Debug.WriteLine(i + " " + arr[i]); //print the information
                }
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
        static bool InHash(string s, string[] arr) {
            try
            {
                //create the hash of the value you want to find
                int hval = BetterHash(s, arr);

                //if the same hash is found...
                if (arr[hval] == s)
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
