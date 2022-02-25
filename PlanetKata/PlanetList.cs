namespace PlanetKata
{
    internal class PlanetList : IPlanetList
    {
        List<IPlanet> _planetList = new List<IPlanet>();
        public IPlanet this[int idx] => _planetList[idx];

        public int AmountWithRings()
        {
            int count = 0;
            for (int i = 0; i < _planetList.Count; i++)
            {
                if (_planetList[i].HasRings == true)
                {
                    count++;
                }
            }
            return count;
        }

        public int Count() => _planetList.Count;

        public int MoonCount()
        {
            int moonCount = 0;
            for (int i = 0; i < _planetList.Count; i++)
            {
                moonCount += _planetList[i].AmountOfMoons;
            }
            return moonCount;
        }

        public void Sort() => _planetList.Sort();

        public int TypeCount(string type)
        {
            int typeCount = 0;
            for (int i = 0; i < _planetList.Count; i++)
            {
                if (_planetList[i].Type.ToLower().Contains(type))
                {
                    typeCount++;
                }
            }
            return typeCount;
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _planetList.Count; i++)
            {
                sRet += $"{_planetList[i]}\n";
                if ((i + 1) % 5 == 0)
                {
                    sRet += "\n";
                }
            }
            return sRet;
        }

        internal static class Factory
        {
            internal static IPlanetList CreatePlanetList(int amount)
            {
                var planetList = new PlanetList();
                for (int i = 0; i < amount; i++)
                {
                    planetList._planetList.Add(Planet.Factory.CreateRandomPlanets());
                }
                return planetList;
            }
        }
        public PlanetList() { }
    }
}
