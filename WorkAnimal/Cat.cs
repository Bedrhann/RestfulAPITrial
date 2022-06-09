using Bedirhan_Hafta_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Work
{
    public class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }
        public int Leg { get; set; }

        public string Breath()
        {
            return "Kedi nefes aldı";
        }
        public string Run()
        {
            return "Kedi koştu";
        }
    }
}
