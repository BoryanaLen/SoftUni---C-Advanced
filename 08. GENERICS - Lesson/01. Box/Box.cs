using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxList;

        public int Count
        {
            get { return this.boxList.Count; }
        }

        public Box()
        {
            boxList = new List<T>();
        }

        public void Add(T element)
        {
            boxList.Add(element);
        }

        public T Remove()
        {
            var item =  boxList[Count-1];
            this.boxList.RemoveAt(Count - 1);
            return item;
        }
    }
}
