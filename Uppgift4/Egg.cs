using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    class Egg
    {
        public int Weight { get; set; }

        public Egg(int weight)
        {
            Weight = weight; // Sätter vikten när ägget skapas. 
        }

        public Egg LayEgg2() // Vill returnera ett ägg
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            if (randomNumber <= 0.48)
            {
                return new Egg(random.Next(20,80)); // Måste nya upp ägget innan jag returnerar den. 
            }
            else
            {
                return null;
            }

        }
    }
}
