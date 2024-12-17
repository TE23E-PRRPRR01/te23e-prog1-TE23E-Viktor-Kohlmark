Console.Clear();


List<string> ListaSpel = [];

// Skriv in två spel 
while (true)
{
    Console.Write(""" 
    ================
    1. Skriv in spel
    2. Vissa listan 
    ================
    Svar: 
    """);

    string val = Console.ReadLine();

    if (val == "1")
    {
        LaggTillSpel("", 0, ref ListaSpel);
    }
    else if (val == "2")
    {
        string lista = string.Join(", ", ListaSpel);
        Console.WriteLine(lista);
    }

}

static void LaggTillSpel(string spel, int antal, ref List<String> ListaSpel)
{
    Console.WriteLine("Hur många spel vill du skriva?");
    Console.Write("Svar: ");

    if (int.TryParse(Console.ReadLine(), out antal))
    {
        Console.Clear();
        Console.WriteLine("Ange filmer");
        for (var i = 0; i < antal; i++)
        {
            Console.Write($"Film {i + 1}: ");
            spel = Console.ReadLine();
            ListaSpel.Add(spel); 
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("Skrev fel");
    }

}