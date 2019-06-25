using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack()
        {
            collection = new List<T>();
        }

        public void Push(params T[] elements)
        {
            foreach (T element in elements)
            {
                collection.Add(element);
            }
        }

        public T Pop()
        {
            T itemToReturn = default(T);

            if (collection.Count > 0)
            {
                itemToReturn = collection[collection.Count - 1];

                collection.RemoveAt(collection.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }

            return itemToReturn;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
