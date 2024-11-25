using System.Formats.Asn1;

Console.Clear();
Console.WriteLine("List öcningar");

static void ListEtt()
{
    List<string> listName = ["Anna", "Björn", "Cecilia"];

    Console.Write("Namn i följande lista: ");
    foreach (string item in listName)
    {

        Console.Write(item + " ");
    }

}

static void ListaTva(string name)
{
    List<string> listName = ["Anna", "Björn", "Cecilia"];

    Console.WriteLine("Vill du läg till ett namn");

    name = Console.ReadLine();
    listName.Add(name);

    Console.Write("Namn i följande lista: ");
    foreach (string item in listName)
    {
        Console.Write(item + " ");
    }

}

static void ListaTre(string name)
{
    List<string> listName = ["Anna", "Björn", "Cecilia"];

    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));
    Console.WriteLine("Skriv namnet du vill ta bort");

    name = Console.ReadLine();
    listName.Remove(name);
    Console.WriteLine("Nya Listan");
    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));

}

static void ListaFyra(string name)
{
    List<string> listName = ["Anna", "Björn", "Cecilia"];

    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));
    Console.WriteLine("Skriv namnet du vill söka efter");

    name = Console.ReadLine();
    if (listName.Contains(name))
    {
        Console.WriteLine("Namnet finns i listan");
    }
    else
    {
        Console.WriteLine("Namnet finns inte i listan");
    }
}


static void ListaFem(string val)
{
    List<string> listName = ["Cecilia", "Björn", "Anna"];
    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));
    Console.WriteLine("Vill du sortera listan i bokstavsordning? ja/nej");
    val = Console.ReadLine();

    if (val == "ja")
    {
        listName.Sort();
        Console.WriteLine($"Namn i följande lista: {string.Join(", ", listName)}");
        Console.WriteLine("===========================================");
    }
    else
    {
        Console.WriteLine("Ok");
    }
}
while (true)
{

    Console.WriteLine("""
    1. Lista ett 
    2. Lista två lägg till ett namn
    3. Lista tre ta bort ett namn 
    4. Lista fyra sök efter ett namn 
    5. ListaFem
    6. Avsluta

    """);
    string val = Console.ReadLine();

    if (val == "1")
    {
        ListEtt();
    }
    else if (val == "2")
    {
        ListaTva("");
    }
    else if (val == "3")
    {
        ListaTre("");
    }
    else if (val == "4")
    {
        ListaFyra("");
    }
    else if (val == "5")
    {
        ListaFem("");
    }
    else if (val == "6")
    {
        break;
    }
    else
    {
        Console.WriteLine("Felaktigt val");
    }


}