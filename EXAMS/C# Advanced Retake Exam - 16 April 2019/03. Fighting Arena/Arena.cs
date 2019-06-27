using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator target = gladiators.Where(x => x.Name == name).FirstOrDefault();

            if (target != null)
            {
                gladiators.Remove(target);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderBy(x => x.GetStatPower()).LastOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderBy(x => x.GetWeaponPower()).LastOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderBy(x => x.GetTotalPower()).LastOrDefault();
        }

        public int Count
        {
            get { return this.gladiators.Count; }
        }

        public override string ToString()
        {
            return ($"[{this.Name}] - [{this.Count}] gladiators are participating.");
        }
    }
}
