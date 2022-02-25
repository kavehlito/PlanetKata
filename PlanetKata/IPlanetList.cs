using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetKata
{
    internal interface IPlanetList
    {
        public IPlanet this[int idx] { get;}
        int Count();
        int AmountWithRings();
        int MoonCount();
        int TypeCount(string type);
        void Sort();
    }
}
