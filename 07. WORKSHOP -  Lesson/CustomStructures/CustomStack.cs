using System;
using System.Collections.Generic;
using System.Text;

namespace _07._CSharp_Advanced_Workshop_Lab
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;

        private int count;

        public int Count
        {
            get { return this.count; }
        }

        public CustomStack()
        {
            this.count = 0;
            items = new int[InitialCapacity];
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public void Push(int element)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.count] = element;

            count++;
        }

        private void Shrink()
        {
            Shrink(items.Length * 2);
        }

        private void Shrink(int newSize)
        {
            int[] copy = new int[newSize];

            this.items.CopyTo(copy, 0);

            this.items = copy;
        }

        public int Pop()
        {
            if(this.items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int element = this.items[this.count - 1];

            this.count--;

            if (this.count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        public int Peek()
        {
            if(this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int element = this.items[this.count - 1];

            return element;
        }

        public void Foreach(Action<object> action)
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
