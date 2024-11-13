// DungeonGame - Ett spel som körs i konsolen 
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Console.Clear();
Console.WriteLine("Välkommen till DungeonGame!");

int liv = 10;

int combat(int liv, int dvärgliv)
{
    Random random = new Random();
    while (liv > 0 && dvärgliv > 0)
    {
        Console.Clear();
        Console.WriteLine("Dvärgen har " + dvärgliv + " liv kvar.");
        Console.WriteLine("Du har " + liv + " liv kvar.");
        Console.ReadKey();
        int attackdvärg = random.Next(1, 4);
        int attackplayer = random.Next(1, 4);

        dvärgliv -= attackplayer;
        Console.WriteLine("Du attackerar dvärgen och gör " + attackplayer + " skada.");
        Console.WriteLine("Dvärgen har " + dvärgliv + " liv kvar.");
        Console.ReadKey();
        
        if (dvärgliv <= 0)
        {
            Console.WriteLine("Dvärgen har inga liv kvar.");
            Console.WriteLine("Du vann striden! och har " + liv + " liv kvar.");
            Console.ReadKey();
            Console.Clear();
            

            break;
        }

        Console.WriteLine($"Dvärgen attackerar dig och gör {attackdvärg} skada.");
        liv = liv - attackdvärg;
        Console.WriteLine("Du har " + liv + " liv kvar.");
        Console.ReadKey();

        if (liv < 0)
        {
            Console.WriteLine("Du har inga liv kvar. Du förlorade striden.");
            Console.ReadKey();

            break;
        }

    }
    return liv;
}
// Programvariabler
string rum = "hallen";  // Starta i "hallen"
List<string> inventarie = [];

while (true)
{
    // Meny 
    Console.WriteLine("""
    1. Titta runt
    2. Gå vidare
    3. Villa
    4. Leta efter gömda föremål
    Vad vill du göra?     
    """);
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.WriteLine("Du tittar runt i rummet och ser mörka hörn.");
        Console.WriteLine("Det känns som att någon eller något tittar på dig...");
        Console.WriteLine("Vill du gå in? (j/n)");
        val = Console.ReadLine();
        if (val == "j")
        {
            rum = "dvärg"; 
            Console.WriteLine("Du möter en Dvärg som drar sin yxa...");
            Console.WriteLine("Vill du slåss? (j/n)");
            val = Console.ReadLine();
            if (val == "j")
            {
                Console.WriteLine("Du väljer att slåss mot dvärgen...");
                combat(liv, 5);
                Console.WriteLine("Du van över dvärgen och hittar en nyckel!");
                inventarie.Add("nyckel");
                liv = liv + 5;
                Console.WriteLine("Du får tillbaka 5 liv. Du har " + liv + " liv kvar.");
                Console.ReadKey();
                Console.Clear();
             
            }
        }
        else if (val == "2")
        {
            rum = "rum 1"; // Flytta till nästa rum
            Console.WriteLine("Du går vidare till nästa rum...");
        }
        else if (val == "3")
        {
            rum = "villa"; // Flytta till "villa"
            Console.WriteLine("Du går vilse och hamnar i en villa...");
        }
        else if (val == "4")
        {
            Console.WriteLine("Du letar efter gömda föremål...");
            Console.WriteLine("Men du hittar ingenting!");
        }
    }
}