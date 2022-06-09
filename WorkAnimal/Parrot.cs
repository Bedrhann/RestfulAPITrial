using Bedirhan_Hafta_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Work
{
    public class Parrot : IAnimal, IBird
    {
        public string Name { get; set; }
        public int Leg { get; set; }

        public string Breath()
        {
            return "Papağan nefes aldı";
        }
        public string Fly()
        {
            return "Papağan uçtu";
        }
    }
}
