using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    public class pqItem
    {
        public int priority = 0;
        public Object value = new object();

        public pqItem(Object value, int priority) {
            this.value = value;
            this.priority = priority;
        }
    }

    class _PriorityQueue<T> where T : IComparable
    {
        private List<pqItem> list = new List<pqItem>();

        public _PriorityQueue()
        {

        }

        /// <summary>
        /// add a new item to the queue (start)
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item, int priority)
        {
            //add the item to the list
            list.Insert(0, new pqItem(item, priority));

            //order the list for priority
            list.Sort((x, y) =>
                    x.priority.CompareTo(y.priority));
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
            list = new List<pqItem>();
        }

        /// <summary>
        /// remove the newest item from the queue (first)
        /// </summary>
        /// <returns></returns>
        public Object deQueue()
        {
            //Load the newest item
            Object item = list.First().value;

            //remove last item from the list
            list.Remove(list.First());

            //return removed item
            return item;
        }

        /// <summary>
        /// return the newest item on the queue
        /// </summary>
        /// <returns></returns>
        public Object Peek()
        {
            return list.First().value;
        }

        /// <summary>
        /// return all items in the queue
        /// </summary>
        public void loop()
        {
            for (int i = 0; i < (list.Count - 1); i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
