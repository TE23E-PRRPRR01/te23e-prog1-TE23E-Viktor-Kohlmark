Console.Clear();
// Hur man skapar arrays 
Console.WriteLine("Program för att skapa listor vi att bygga ett kortspel");
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Listor 
List<string> varde = ["Ess", "Två", "Tre", "Fyra", "Fem", "Sexa", "Sju", "Åtta", "Nio", "Tio", "Knekt", "Dam", "Kung"];
List<string> Farger = ["Hjärter", "Ruter", "Klöver", "Spader"];

// Lägg in färger i kortlek 
List<string> kortlek = new List<string>();
foreach(var Farg in Farger) 
{
    foreach(var kort in varde) 
    {
        kortlek.Add($"{Farg} {kort}");
    }
}

Console.WriteLine("------------");
for (int i = 0; i < 5; i++) 
{
    int slumpindex = Random.Shared.Next(0, kortlek.Count);
    string slumpkort = kortlek[slumpindex];
    kortlek.RemoveAt(slumpindex);
    Console.WriteLine(slumpkort);
}
