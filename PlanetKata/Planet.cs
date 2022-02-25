namespace PlanetKata
{
    internal class Planet : IPlanet
    {
        public PlanetName Name { get; set; }
        public double Mass { get; set; }
        public string Type { get; set; }
        public int AmountOfMoons { get; set; }
        public bool HasRings { get; set; }

        public override string ToString()
        {
            string hasRings;
            string moons;
            if (HasRings == true)
            {
                hasRings = "This planet has rings";
            }
            else hasRings = "This planet does NOT have rings";

            if (AmountOfMoons == 0)
            {
                moons = "This planet does NOT have any moons";
            }
            if (AmountOfMoons == 1)
            {
                moons = "This planet has one moon";
            }
            else moons = $"This planet has {AmountOfMoons} moons";


            return $"Planet {Name} is a {Type} planet and it has the mass of {Mass} Earths. {moons}. {hasRings}";
        }
        public int CompareTo(IPlanet? other)
        {
            if (Mass != other.Mass)
            {
                return Mass.CompareTo(other.Mass);
            }
            if (AmountOfMoons != other.AmountOfMoons)
            {
                return AmountOfMoons.CompareTo(other.AmountOfMoons);
            }
            if (Type != other.Type)
            {
                return Type.CompareTo(other.Type);
            }
            if (HasRings != other.HasRings)
            {
                return HasRings.CompareTo(other.HasRings);
            }
            return Name.CompareTo(other.Name);
        }

        public bool Equals(IPlanet? other)
        {
            return (this.Mass, this.AmountOfMoons, this.Type, this.HasRings, this.Name) == (other.Mass, other.AmountOfMoons, other.Type, other.HasRings, other.Name);
        }
        public override bool Equals(object? obj) => Equals(obj as IPlanet);
        public override int GetHashCode() => (this.Mass, this.AmountOfMoons, this.Type, this.HasRings, this.Name).GetHashCode();

        public void RandomInit()
        {
            var rnd = new Random();
            bool bALLOk = false;
            while (!bALLOk)
            {
                try
                {
                    double[] _mass = { 0.06, 0.81, 1.00, 0.11, 317.83, 95.16, 14.54, 17.15, 0.0022 };
                    string[] _type = "Terrestrial GasGiant IceGiant DwarfPlanet".Split(' ');
                    int[] _moons = { 0, 0, 1, 2, 80, 83, 27, 14 };

                    this.Name = (PlanetName)rnd.Next((int)PlanetName.Mercury, (int)PlanetName.Pluto + 1);
                    this.HasRings = rnd.Next(2) == 0;
                    this.Mass = _mass[rnd.Next(0, _mass.Length)];
                    this.Type = _type[rnd.Next(0, _type.Length)];
                    this.AmountOfMoons = _moons[rnd.Next(0, _moons.Length)];

                    bALLOk = true;
                }
                catch { }
            }
        }
        internal static class Factory
        {
            internal static IPlanet CreateRandomPlanets()
            {
                var planet = new Planet();
                planet.RandomInit();
                return planet;
            }
        }
        public Planet() { }
    }
}
