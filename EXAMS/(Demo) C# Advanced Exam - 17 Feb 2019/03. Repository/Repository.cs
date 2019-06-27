using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private int id = 0;

        private Dictionary<int,Person> dictionary;

        public Repository()
        {
            this.dictionary = new Dictionary<int, Person>();
        }

        public void Add(Person person)
        {
            dictionary.Add(id, person);
            id++;
        }

        public Person Get(int id)
        {
            Person foundPerson = null;

            if (dictionary.ContainsKey(id))
            {
                foundPerson = dictionary[id];
            }

            return foundPerson;
        }

        public bool Update(int id, Person newPerson)
        {
            bool result = false;

            if (dictionary.ContainsKey(id))
            {
                dictionary[id] = newPerson;
                result = true;
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            if (dictionary.ContainsKey(id))
            {
                dictionary.Remove(id);
                result = true;
            }

            return result;
        }

        public int Count
        {
            get { return this.dictionary.Count; }
        }
    }
}
