using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire>Tires { get; set; }

        public Car(string model)
        {
            Model = model;
            Tires = new List<Tire>(4);
            Cargo = new Cargo();
            Engine = new Engine(); 
        }
    }
}
