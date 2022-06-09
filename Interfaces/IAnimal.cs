using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Leg { get; set; }
        string Breath();


    }
}
