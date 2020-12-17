using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class Hen : HenHouse
    {

        public string Breed { get; set; }
        public double Weight { get; set; }

        //        /*
        //* Lägger metoden här för att då kommer jag kunna avgöra om hönan lägger ägg. Det är ju hönan som lägger ägg och inte Hönshuset. 
        //*
        //*
        //*/

        public int LayEgg()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            if (randomNumber <= 0.48)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public Egg LayEgg2() // Vill returnera ett ägg
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            if (randomNumber <= 0.48)
            {
                return new Egg(random.Next(20, 80)); // Måste nya upp ägget innan jag returnerar den. 
            }
            else
            {
                return null;
            }

        }
    }
}
