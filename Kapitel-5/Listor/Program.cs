// Skapa ett register 
using System.Globalization;

Console.Clear();

// Listan 
List<string> namnLista = [];

static void PrintNames(List<string> namn)
{
    Console.WriteLine("-------- List --------");
    foreach (var name in namn)
    {
        Console.WriteLine(name);
    }
}

Console.WriteLine("Kommer att spara namn fårn klassen");
while (true)
{

    Console.WriteLine("----------");
    Console.WriteLine("Vill du avsluta skriv (exit) vill du se listan skriv (list) ");

    Console.Write("Skriv namn - ");
    string namn = Console.ReadLine();
    namnLista.Add(namn);

    if (namn == "exit")
    {
        namnLista.Remove(namn);
        
        Console.Clear();
                
        PrintNames(namnLista);

        break;
    }

    else if (namn == "list")
    {
        namnLista.Remove(namn);

        Console.WriteLine();

        PrintNames(namnLista);

    }

}
