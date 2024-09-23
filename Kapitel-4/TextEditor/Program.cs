// Program för att vissa menyer 
Console.Clear();
Console.WriteLine("Välkommen till menyn!");
// Variabel för texten
string text = "";
// Variabel för valet 
String val = "";    // Variablen för valet vi gör 

while(true) {
    Console.WriteLine("1. Spara till fil");
    Console.WriteLine("2. Läs från fil");
    Console.WriteLine("3. Avsluta");
    Console.WriteLine("-----------------");
    Console.Write("Välj: ");

    val = Console.ReadLine(); 
    Console.Clear(); // Informationen kommer att hammna över menyn
    if(val == "1") {
        Console.WriteLine("Skriv Texten eller tryck på return för att gå ut");
        text = Console.ReadLine();
        File.WriteAllText("output.txt", text);
        Console.WriteLine("texten har sparats ");
    }
    else if(val == "2") {
            Console.Clear();
            Console.WriteLine("Läser från filen vänta ...");
            text = File.ReadAllText("output.txt"); // 
            Console.WriteLine("Texten läs ur filen ->");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(text); // Skriver ut texten
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }
    else if(val == "3") {
        break;
    }
    else {
        Console.WriteLine("Felaktigt val, försök igen!");
    }
}