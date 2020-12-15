using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift4
{
    public class HenHouse
    {
        public List<Hen> Hens { get; set; }
        public string Stable { get; set; }

        public HenHouse()
        {
            Hens = new List<Hen>();
        }
    }
}
