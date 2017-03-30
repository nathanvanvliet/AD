using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eindopdracht
{
    class MyArrayList<T> : IEnumerable
    {

        private int index = 0;
        private T[] array = new T[0];

        public void Add(T value)
        {
            if (index == array.Length)
            {
                sizeUpArray();
            }
            if (index < array.Length)
            {
                array[index] = value;
                index++;
            }
        }

        public void removeAt(int index)
        {
            List<T> temp = new List<T>(array);
            temp.RemoveAt(index);
            array = temp.ToArray();
            index--;
        }

        public void remove(T value)
        {
            List<T> temp = new List<T>(array);
            temp.Remove(value);
            array = temp.ToArray();
            index--;
        }

        public void addRange(ICollection values)
        {

            int c = values.Count;
            for (int i = 0; i < c; i++)
            {
                sizeUpArray();
            }
            if (index < array.Length)
            {
                values.CopyTo(array, index);
                index += c;
            }

        }

        public int Count()
        {
            return array.Length;
        }

        public T getIndex(int index)
        {
            T toGet = array[index];
            return toGet;
        }

        public void clear()
        {
            index = 0;
            Array.Resize(ref array, 0);
        }

        public int Capacity()
        {
            return array.Length;
        }

        public bool contains(T item)
        {
            foreach (T value in array)
            {
                if (value.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T[] CopyTo(T[] newArray)
        {
            newArray = array;
            return newArray;
        }

        public int indexOf(T item)
        {
            int l = array.Length;
            for (int i = 0; i < l; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }


        public void sizeUpArray()
        {
            Array.Resize(ref array, array.Length + 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MyEnum<T> GetEnumerator()
        {
            return new MyEnum<T>(array);
        }


    }

    // IEnumerator class for foreach loop
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

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

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

