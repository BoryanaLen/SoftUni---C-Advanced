using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engie)
        {
            Model = model;
            Engine = engie;
            Weight = "n/a";
            Color = "n/a";
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            sb.AppendLine($"  Weight: {Weight}");
            sb.AppendLine($"  Color: {Color}");

            return sb.ToString();
        }
    }
}
