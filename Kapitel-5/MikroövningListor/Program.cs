using System.Formats.Asn1;

Console.Clear();
Console.WriteLine("List öcningar");
    List<string> listName = ["Anna", "Björn", "Bellamn", "Berit","Cecilia"];


static void ListEtt(List<string> listName)
{

    Console.Write("Namn i följande lista: ");
    foreach (string item in listName)
    {

        Console.Write(item + " ");
    }

}

static void ListaTva(string name, List<string> listName)
{

    Console.WriteLine("Vill du läg till ett namn");

    name = Console.ReadLine();
    listName.Add(name);

    Console.Write("Namn i följande lista: ");
    foreach (string item in listName)
    {
        Console.Write(item + " ");
    }

}

static void ListaTre(string name, List<string> listName)
{

    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));
    Console.WriteLine("Skriv namnet du vill ta bort");

    name = Console.ReadLine();
    listName.Remove(name);
    Console.WriteLine("Nya Listan");
    Console.WriteLine("Namn i följande lista: " + string.Join(", ", listName));

}

static void ListaFyra(string name, List<string> listName)
{

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


static void ListaFem(string val, List<string> listName)
{
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

static void ListaSex(string name, char bokstav, List<string> listName) 
{

    Console.WriteLine("Vilken bokstav vill du söka efter? ");
    char.TryParse(Console.ReadLine(), out bokstav);

    foreach (string namne in listName) {
        if (name.StartsWith(bokstav)) {
            Console.WriteLine(name);
        }
    }
    


}

while (true)
{

    Console.WriteLine("""
    1. Lista ett Skriv ut namnen i listan
    2. Lista två lägg till ett namn
    3. Lista tre ta bort ett namn 
    4. Lista fyra sök efter ett namn 
    5. ListaFem sortera listan i bokstavsordning
    6. Avsluta

    """);
    string val = Console.ReadLine();

    if (val == "1")
    {
        ListEtt(listName);
    }
    else if (val == "2")
    {
        ListaTva("", listName);
    }
    else if (val == "3")
    {
        ListaTre("", listName);
    }
    else if (val == "4")
    {
        ListaFyra("", listName);
    }
    else if (val == "5")
    {
        ListaFem("", listName);
    }
    else if (val == "6")
    {
    ListaSex("", ' ', listName);
    }
    else if (val == "7")
    {
        break;
    }
    else
    {
        Console.WriteLine("Felaktigt val");
    }


}