using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetKata
{
    public enum PlanetName { Mercury, Venus, Tellus, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto}
    internal interface IPlanet : IEquatable<IPlanet>, IComparable<IPlanet>
    {
        public PlanetName Name { get; set; }
        public double Mass { get; set; }
        public string Type { get; set; }
        public int AmountOfMoons { get; set; }
        public bool HasRings { get; set; }

        public void RandomInit();
    }
}
