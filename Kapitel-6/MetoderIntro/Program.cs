Console.Clear();
Console.WriteLine("Hej metoder!");

// Anropa metoden 

sägHej();

// Anropa metoden meny 
VisaMeny();

/// <summary>
/// Metod som skriver ut en hälsning 
/// </summary>

static void sägHej()
{
    Console.WriteLine("Hej ");
}

/// <summary>
/// Metod för att visa en meny 
/// </summary>

static void VisaMeny()
{
    Console.WriteLine(""" 
    1. Lägg till uppgift
    2. Ta bort uppgift 
    3. Skriv ut alla uppgifter 
    4. Avsluta
    """);
}

