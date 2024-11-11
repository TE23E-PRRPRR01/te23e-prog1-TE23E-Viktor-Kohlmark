Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");
Console.WriteLine("==================================");

// Globala variabler 
// En lista för heltal 
List<int> listaslumptal = [];


Console.WriteLine("Skriv vilka tal som ska slumpas");
Console.WriteLine("==================================");

// Fråga användaren om min och max värden samt hur många gåner det ska slumpas
Console.Write("Lägsta tal: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Högsta tal: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Hur många gånger ska det slumpas: ");
int antal = int.Parse(Console.ReadLine());

// Skapa en loop som slumpar fram ett tal och lägger till i listan
// Loopa 5 ggr 
for (int i = 0; i < antal; i++)
{

    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägg till slumptalet i listan
    listaslumptal.Add(slumptal);
    Console.WriteLine($"Slumptal {i + 1}: {slumptal}");

}