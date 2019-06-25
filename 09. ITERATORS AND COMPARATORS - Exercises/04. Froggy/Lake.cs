using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> collection;

        public Lake(List<int> stones)
        {
            this.collection = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return collection[i];
                }
            }

            for (int j = collection.Count - 1; j >= 0; j--)
            {
                if (j % 2 != 0)
                {
                    yield return collection[j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
