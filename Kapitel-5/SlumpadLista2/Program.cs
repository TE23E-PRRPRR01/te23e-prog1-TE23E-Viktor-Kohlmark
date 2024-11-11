// Skapa en lista som innehåller 5 slumptal mellan min och max. Skriv ut listan.

/* *********************************************************************
**                               Main                                 **
********************************************************************* */

Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");
Console.WriteLine("==================================");

// Globala variabler 

// En lista för heltal 
List<int> listaslumptal = [];

Console.WriteLine("Skriv vilka tal som ska slumpas");
Console.WriteLine("==================================");

int antalStor = LäsInheltal( out int min, out int max, out int antal);

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

/* *********************************************************************
**                         Mina egna metoder                          **
********************************************************************* */

static int LäsInheltal( out int min, out int max, out int antal)
{
    // Fråga användaren om min och max värden samt hur många gåner det ska slumpas
    while (true)
    {
        Console.Write("Lägsta tal: ");
        bool lyckadesMin = int.TryParse(Console.ReadLine(), out  min);
        Console.Write("Högsta tal: ");
        bool lyckadesMax = int.TryParse(Console.ReadLine(), out  max);
        Console.Write("Hur många gånger ska det slumpas: ");
        bool lyckadesAntal = int.TryParse(Console.ReadLine(), out  antal);

        if (!lyckadesMin || !lyckadesMax || !lyckadesAntal)
        {
            Console.Clear();
            Console.WriteLine("Felaktig inmatning");
        }
        else
        {
            break;
        }
    }

}