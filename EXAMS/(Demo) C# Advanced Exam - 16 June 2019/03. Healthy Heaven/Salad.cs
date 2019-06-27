using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;

        public string Name { get; private set; }

        public Salad(string name)
        {
            this.Name = name;
            this.vegetables = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            return vegetables.Sum(x => x.Calories);
        }

        public int GetProductCount()
        {
            return this.vegetables.Count;
        }

        public void Add(Vegetable product)
        {
            this.vegetables.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"* Salad {this.Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");

            foreach(Vegetable veg in this.vegetables)
            {
                sb.AppendLine(veg.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
