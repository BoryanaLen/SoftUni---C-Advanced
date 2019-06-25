using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
    {
        private T value;

        public T Value
        {
            get { return this.value; }
        }


        public Box(T value)
        {
            this.value = value;
        }

        public int CompareTo(Box<T> element)
        {
            return value.CompareTo(element.Value);
        }

        public override string ToString()
        {
            string result = $"{value.GetType()}: {value}";

           return result;
        }
    }
}
