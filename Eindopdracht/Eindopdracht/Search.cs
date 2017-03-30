using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class Search<T> where T : IComparable
    {
        public static int lastSeqSearch(T[] arr, T searchValue)
        {
            int position = -1;
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (arr[i].Equals(searchValue))
                {
                    position = i;
                }
            }
            return position;
        }

        public static int firstSeqSearch(T[] arr, T searchValue)
        {
            int compCount = 0;
            int position = -1;
            int length = arr.Length;
            int found = 0;
            for (int i = 0; i < length && found != 1; i++)
            {
                compCount++;
                if (arr[i].Equals(searchValue))
                {
                    position = i;
                    found = 1;
                    Console.WriteLine("it took sequential search {0} iterations to complete the search", compCount);
                }
            }
            return position;
        }

        public static int occuranceSeqSearch(T[] arr, T searchValue, int occ)
        {
            int o = 1;
            int position = -1;
            int length = arr.Length;
            int found = 0;
            for (int i = 0; i < length && found != 1; i++)
            {
                if (arr[i].Equals(searchValue))
                {
                    if (o == occ)
                    {
                        position = i;
                        found = 1;
                    }
                    else
                    {
                        o++;
                    }
                }
            }
            return position;
        }

        public static T FindMin(T[] arr)
        {
            T min = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }

            return min;
        }

        public static T FindMax(T[] arr)
        {
            T max = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            return max;
        }

        public static int binarySearch(T[] arr, T searchValue)
        {
            // FIRST HAVE TO SORT THE ARRAY, USING ONE OF HENKS SORT METHODS
            Array.Sort(arr);
            int min, max, middle, compCount;
            compCount = 0;
            min = 0;
            max = arr.Length - 1;
            while (min <= max)
            {
                compCount++;
                middle = (int)Math.Round((min + max) / 2.0, MidpointRounding.AwayFromZero);
                if (searchValue.CompareTo(arr[middle]) == 0)
                {
                    Console.WriteLine("it took Binary search {0} iterations to complete the search", compCount);
                    return middle;
                }
                else if (searchValue.CompareTo(arr[middle]) < 0)
                {
                    max = middle - 1;
                }
                else if (searchValue.CompareTo(arr[middle]) > 0)
                {
                    min = middle + 1;
                }
            }
            return -1;
        }

    }
}

