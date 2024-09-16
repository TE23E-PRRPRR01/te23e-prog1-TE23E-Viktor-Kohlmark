// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hej, idag ska du köra ett spel.");
Console.WriteLine("Spelet går ut på att du ska gissa ett hemligt number");

Thread.Sleep(3000);
Console.Clear();   

Console.WriteLine("Vilka numer vill du gissa mellan?");

Console.WriteLine("Skriv in det lägsta numret");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in det högsta numret");
int max = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Gissa numret mellan {min} och {max}");

Random random = new Random();
int baseNumber = random.Next(min, max + 1); // Det hemliga numret

int number = 0;

int antalgissningar = 0;

while (number != baseNumber)
{

    string textNumber = Console.ReadLine(); // Läs in texten 
    number = int.Parse(textNumber); // Konvertera texten till ett heltal

    Console.WriteLine("Vill du avsluta splet? (ja/nej)");
    string jaNej = Console.ReadLine();

    if (jaNej == "ja")
    {
        Console.WriteLine("Spelet avslutas");
        break;
    }else if (jaNej == "nej")
    {
        Console.WriteLine("Spelet fortsätter");
    }

    antalgissningar++;

    if (number > baseNumber)
    {
        Console.WriteLine("För högt!");
    }
    else if (number < baseNumber)
    {
        Console.WriteLine("För lågt!");
    }
    else
    {
        Console.WriteLine($"Rätt svar! {number} är korrekt!");
        Console.WriteLine("Antal gissningar: " + antalgissningar);
    }
}


