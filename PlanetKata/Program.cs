using PlanetKata;

/*var planet1 = Planet.Factory.CreateRandomPlanets();
var planet2 = Planet.Factory.CreateRandomPlanets();
var planet3 = Planet.Factory.CreateRandomPlanets();

Console.WriteLine(planet1);
Console.WriteLine(planet2);
Console.WriteLine(planet3);
Console.WriteLine();*/

var planetList1 = PlanetList.Factory.CreatePlanetList(10);

planetList1.Sort();
Console.WriteLine(planetList1);
Console.WriteLine($"Planets with rings: {planetList1.AmountWithRings()}");
Console.WriteLine();
Console.WriteLine($"Total amount of moons: {planetList1.MoonCount()}");
Console.WriteLine();

Console.WriteLine("What planet type would you like to look up...?\n");
string userTypeInput = Console.ReadLine().ToLower();
Console.WriteLine();
Console.WriteLine($"Amount of {userTypeInput} planets: {planetList1.TypeCount(userTypeInput)}");

Console.WriteLine(planetList1[5]);