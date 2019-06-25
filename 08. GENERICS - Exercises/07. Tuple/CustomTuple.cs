using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTuple
{
    public class CustomTuple<T, U>
    {
        public CustomTuple(T itemOne, U ItemTwo)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = ItemTwo;
        }

        public T ItemOne { get; private set; }
        public U ItemTwo { get; private set; }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemTwo}";
        }
    }
}
