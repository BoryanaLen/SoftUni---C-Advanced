using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;

        public string Name { get; private set; }

        public Restaurant(string name)
        {
            this.Name = name;
            salads = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            salads.Add(salad);
        }

        public bool Buy(string name)
        {
            bool result = false;

            Salad saladToRemove = salads.Where(x => x.Name == name).FirstOrDefault();

            if (saladToRemove != null)
            {
                int index = salads.IndexOf(saladToRemove);

                result = true;

                salads.RemoveAt(index);
                
            }

           return result;
        }

        public Salad GetHealthiestSalad()
        {
            string result = string.Empty;

            Salad found = salads.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();

            if (found != null)
            {
                result = found.Name;
            }

            return found;
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} have {this.salads.Count} salads:");

            foreach(Salad salad in salads)
            {
                sb.AppendLine(salad.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
