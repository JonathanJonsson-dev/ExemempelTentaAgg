using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class HenHouse
    {

        public List<Hen> Hens { get; set; } =  new List<Hen>();
        public string Stable { get; set; }

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
    }
}
