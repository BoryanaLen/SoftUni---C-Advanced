using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        private List<Astronaut> collection;

        public int Count
        {
            get { return this.collection.Count; }
        }

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.collection = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            this.collection.Add(astronaut);
        }

        public bool Remove(string name)
        {
            bool result = false;

            Astronaut target = this.collection.Where(x => x.Name == name).FirstOrDefault();

            if (target != null)
            {
                this.collection.Remove(target);
                result = true;
            }

            return result;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut target = this.collection.OrderBy(x => x.Age).LastOrDefault();

            return target;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut target = this.collection.Where(x => x.Name == name).LastOrDefault();

            return target;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach(var astr in this.collection)
            {
                sb.AppendLine(astr.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
