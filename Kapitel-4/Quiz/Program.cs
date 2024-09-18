Console.Clear();
Console.WriteLine("Detta är ett quiz!");
Console.WriteLine("Lycka till!");
Console.WriteLine("Tryck på valfri tangent för att starta spelet . . . ");
Console.ReadKey();
Console.Clear();
int  antalgissningarFel = 0;
int antalrättagissningar = 0;

Console.WriteLine("Vad heter huvudstaden i Sverige?");
while (true)
{
    Console.Write("Svar: ");
    string answer = Console.ReadLine();
    if (answer == "Stockholm")
    {
        Console.WriteLine("Rätt svar!");
        antalrättagissningar++;
        Console.Clear();
        break;
    }   
    else
    {
        Console.WriteLine("Fel svar, försök igen!");
        antalgissningarFel++;

    }
}

Console.WriteLine("Vad heter huvudstaden i Finland? På svenska.");
while (true)

{
    Console.WriteLine("a) Helsingfors");
    Console.WriteLine("b) Helsinki");
    Console.WriteLine("c) Helsingborg");
    string answer = Console.ReadLine();
    if (answer == "a")
    {
        Console.WriteLine("Rätt svar!");
        antalrättagissningar++;
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Fel svar, försök igen!");
        antalgissningarFel++;
    }
}

Console.WriteLine("Vad heter huvudstaden i Norge?");
while (true)
{   
    Console.WriteLine("a) Stockholm");
    Console.WriteLine("b) Oslo");
    Console.WriteLine("c) Helsingfors");   
    string answer = Console.ReadLine().ToLower();
    


    if (answer == "b")
    {
        Console.WriteLine("Rätt svar!");
        antalrättagissningar++;
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Fel svar, försök igen!");
        antalgissningarFel++;
    }
}

Console.WriteLine("Vad heter huvudstaden i Island?");
while (true)
{
    
    Console.WriteLine("a) Reykjavik");
    Console.WriteLine("b) Oslo");
    Console.WriteLine("c) Helsingfors");    
    string answer = Console.ReadLine();


    if (answer == "a")
    {
        Console.WriteLine("Rätt svar!");
        antalrättagissningar++;
        Console.Clear();
        break;
        
    }
    else
    {
        Console.WriteLine("Fel svar, försök igen!");
        antalgissningarFel++;
    }

}

Console.WriteLine($"Du hade {antalgissningarFel} fel och {antalrättagissningar} rätt. ");