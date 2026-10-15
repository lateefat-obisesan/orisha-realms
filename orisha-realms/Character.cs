using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
    public class Character
    {
        public string Name { get; set; }
        public string Lineage { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }

        public Character (string name, string lineage, int health, int defense, int speed, int strength, int intellect, int agility)
        {
            Name = name;
            Lineage = lineage;
            Health = health;
            Defense = defense;
            Speed = speed;
            Strength = strength;
            Intellect = intellect;
            Agility = agility;
        }

        public Virtual void Act()
        {
            Console.WriteLine(Name + "takes action.");
        }

        public virtual void Speak()
        {
            Console.WriteLine(Name + " says: I am ready.");
        }

        public void PrintDetails()
        {
            Console.WriteLine("\n--- Character Details ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lineage: " + Lineage);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Intellect: " + Intellect);
            Console.WriteLine("Agility: " + Agility);
        }
    }
}
