using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class HenHouse
    {

        public List<Hen> Hens { get; set; } =  new List<Hen>();
        public string Stable { get; set; }
        public List<Egg> eggs { get; set; } = new List<Egg>();

        public void CreateHenHouse(int numberOfHens)
        {
            for (int i = 0; i < numberOfHens; i++)
            {
                Hens.Add(new Hen()); // Nyar upp en höna och lägger till den i listan hönor. 
            }
         
        }
        // Lägger den i hönshuset då det blir enkelt att komma åt listan med hönor. 
        public int CountEggs()
        {
            int sum = 0;
            foreach (Hen hen in Hens)
            {
                sum += hen.LayEgg();
            }
            return sum;
        }
        // Lägger denna i hönshuset då du hämtar äggen från ett hus

        public List<Egg> CollectEggs()
        {
            foreach (Hen hen in Hens)
            {
                Egg egg = hen.LayEgg2();
                if (egg != null)
                {
                    eggs.Add(egg);
                }

            }
            return eggs;


        } 


    }
}
