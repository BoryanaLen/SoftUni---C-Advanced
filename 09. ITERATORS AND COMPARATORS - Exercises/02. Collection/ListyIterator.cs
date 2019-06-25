using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;

        private int indexPosition;

        public ListyIterator()
        {
            this.collection = new List<T>();
            indexPosition = 0;
        }

        public ListyIterator(List<T> collection) : base()
        {
            this.collection = collection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return collection[indexPosition];
        }

        public bool HasNext()
        {
            bool result = false;

            if (indexPosition + 1 < collection.Count)
            {
                result = true;
            }

            return result;
        }

        public bool Move()
        {
            bool result = false;

            if (HasNext())
            {
                indexPosition++;
                result = true;
            }

            return result;
        }

        public void Print()
        {
            if(this.collection.Count == 0)
            {
                throw new NullReferenceException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(collection[indexPosition]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(' ', collection));
        }
    }
}
