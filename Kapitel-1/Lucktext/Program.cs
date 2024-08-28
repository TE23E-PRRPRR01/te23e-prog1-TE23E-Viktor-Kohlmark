Console.WriteLine("Hello");

Console.Write("Name : ");
String name = Console.ReadLine();

Console.Write("Sport : ");
String game = Console.ReadLine();

Console.WriteLine("Levndas ort : ");
String city = Console.ReadLine();

Console.Clear();

if(city == "Tullinge")
{
	Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Bad");
}

Console.WriteLine($"Hello {name}! Welcome to the game {game} in the city of {city}.");
