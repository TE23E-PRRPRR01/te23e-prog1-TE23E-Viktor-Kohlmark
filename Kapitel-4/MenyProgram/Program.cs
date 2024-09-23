// Program för att vissa menyer 
Console.Clear();
Console.WriteLine("Välkommen till menyn!");

// Variabel för valet 
String val = "";    // Variablen för valet vi gör 

while(true) {
    Console.WriteLine("1. Tid");
    Console.WriteLine("2. Datum");
    Console.WriteLine("3. Avsluta");
    Console.WriteLine("-----------------");
    Console.Write("Välj: ");

    val = Console.ReadLine(); 
    Console.Clear(); // Informationen kommer att hammna över menyn
    if(val == "1") {
        Console.WriteLine("Klockan är: " + DateTime.Now.ToString("HH:mm:ss")); // Timmar, minuter och sekunder
        Console.WriteLine("-----------------");

    }
    else if(val == "2") {
        Console.WriteLine("Datumet är: " + DateTime.Now.ToString("yyyy-MM-dd")); // ÅR, månader och dagar
        Console.WriteLine("-----------------");
    }
    else if(val == "3") {
        break;
    }
    else {
        Console.WriteLine("Felaktigt val, försök igen!");
    }
}