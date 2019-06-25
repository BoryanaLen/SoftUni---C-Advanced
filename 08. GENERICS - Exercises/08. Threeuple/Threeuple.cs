using System;
using System.Collections.Generic;
using System.Text;

namespace GenericThreeuple
{
    public class Threeuple<T, U, V>
    {
        public Threeuple(T itemOne, U itemTwo, V itemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
            this.ItemThree = itemThree;
        }

        public T ItemOne { get; private set; }
        public U ItemTwo { get; private set; }
        public V ItemThree { get; private set; }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemTwo} -> {this.ItemThree}";
        }
    }
}
