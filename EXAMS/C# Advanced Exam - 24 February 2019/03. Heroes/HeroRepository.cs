using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public int Count
        {
            get { return this.heroes.Count; }
        }

        public void Remove(string name)
        {
            Hero target = this.heroes.Where(x => x.Name == name).FirstOrDefault();

            if (target != null)
            {
                heroes.Remove(target);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.heroes.OrderBy(x => x.Item.Strength).LastOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.heroes.OrderBy(x => x.Item.Ability).LastOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.heroes.OrderBy(x => x.Item.Intelligence).LastOrDefault();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(var hero in this.heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
