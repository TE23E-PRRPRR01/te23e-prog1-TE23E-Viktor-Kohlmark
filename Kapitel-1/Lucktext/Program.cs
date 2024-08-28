Console.WriteLine("Hello");

Console.Write("Name : ");
string name = Console.ReadLine();


if (name.Length > 0 )
{
    Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Enter name");
    name = Console.ReadLine();  
}

Console.Write("Sport : ");
var sport = Console.ReadLine();

Console.Write("Levndas ort : ");
var city = Console.ReadLine();

Console.Clear();
List<string> swedishCities = new()
{
    "Stockholm",
    "Gothenburg",
    "Malmö",
    "Uppsala",
    "Linköping",
    "Örebro",
    "Västerås",
    "Helsingborg",
    "Norrköping",
    "Jönköping"
};

if (swedishCities.Contains(city))
{
    Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Bad");
}

Console.WriteLine($"Hello {name}! Welcome to the game {sport} in the city of {city}.");
