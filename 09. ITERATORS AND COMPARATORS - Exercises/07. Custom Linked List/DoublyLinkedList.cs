using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Exercise
{
    public class DoublyLinkedList<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private class ListNode
        {
            public T Value { get;}
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }

        }

        private ListNode head;

        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            ListNode newHead = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            var newTail = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            CheckIfEmptyThrowExeption();

            T firstElement = this.head.Value;

            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            Count--;

            return firstElement;
        }

        public T RemoveLast()
        {
            CheckIfEmptyThrowExeption();

            T lastElement = this.tail.Value;

            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            Count--;

            return lastElement;
        }

        public void Print(Action<T> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public bool Contains(T value)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                if(currentNode.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];

            int counter = 0;

            var currentNode = this.head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }

            return array;
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>(this.Count);

            var currentNode = this.head;

            while (currentNode != null)
            {
                list.Add(currentNode.Value);

                currentNode = currentNode.NextNode;
            }

            return list;
        }

        private void CheckIfEmptyThrowExeption()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
