// Spelet sten, sax, påse, ödla, Spock
Console.Clear();
Console.WriteLine("Välkommen till Sten, sax, påse, ödla, Spock!");
Console.WriteLine("""
Spelets regler:
Sten krossar sax
Sten krossar ödla
Sax klipper papper
Sax halshugger ödla
Påse täcker sten
Påse fångar Spock
Ödla äter papper
Ödla förgiftar Spock
Spock krossar sax
Spock smälter sten
""");

while (true)
{
    Console.WriteLine(
    """
    Välj mellan 
    1. Sten 
    2. Påse 
    3. Sax
    4. Ödla 
    5. Spock
    """);
    int answer = int.Parse(Console.ReadLine());
    Random random = new Random();
    int computer = random.Next(1, 6);

    if (answer == 1 && (computer == 3 || computer == 4))
    {
        Console.WriteLine("Du van");
    }
    else if (answer == 3 && (computer == 2 || computer == 4){
        Console.WriteLine("Du van");
    }
    else if (answer == 3 && (computer == 1 || computer == 4){
        Console.WriteLine("Du van");
    }
    else if (answer == 2 && (computer == 2 || computer == 4){
        Console.WriteLine("Du van");
    }
    else if (answer == 2 && (computer == 2 || computer == 4){
        Console.WriteLine("Du van");
    }
}