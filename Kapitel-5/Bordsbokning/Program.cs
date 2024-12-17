// Program för att organizera borden hos resturangen Centralrestaurangen

using System.Runtime.ConstrainedExecution;

Console.WriteLine("Välkommen till Centralrestaurangen! ");


var tables = new List<(string bord, string name, int antal)>
{
    ("Bord 1 -", "", 0),
    ("Bord 2 -", "", 0),
    ("Bord 3 -", "", 0),
    ("Bord 4 -", "", 0),
    ("Bord 5 -", "", 0),
    ("Bord 6 -", "", 0),
    ("Bord 7 -", "", 0),
    ("Bord 8 -", "", 0)
};


static void ListInRow(List<(string bord, string name, int antal)> tables)
{
    Console.Clear();
    Console.WriteLine("================================================");
    foreach (var (bord, name, antal) in tables)
    {
        var displayName = name;
        if (antal == 0)
        {
            displayName = "Inga gäster";
            Console.WriteLine($"{bord} {displayName}");
        }
        else
        {
            Console.WriteLine($"{bord}  Nman = {name} Antal = {antal}");
        }
    }
    Console.WriteLine("================================================");

    Console.WriteLine("Press Enter");
    Console.ReadLine();

}

static void ChangeList(string vall, int gaster, string namn, ref List<(string bord, string name, int antal)> tables)
{
    Console.Clear();
    Console.WriteLine("================================================");
    for (var i = 0; i < tables.Count; i++)
    {
        Console.WriteLine($"{i + 1}. Bord {i + 1}");
    }
    Console.WriteLine("================================================");

    Console.Write("Välj ett bord att ändra (1-8): ");
    if (int.TryParse(Console.ReadLine(), out int tableIndex) && tableIndex >= 1 && tableIndex <= tables.Count)
    {
        tableIndex--; // Adjust for zero-based index
        Console.Write("Ange nytt namn: ");
        string newName = Console.ReadLine();
        Console.Write("Ange antal gäster: ");
        if (int.TryParse(Console.ReadLine(), out int newAntal))
        {
            tables[tableIndex] = (tables[tableIndex].bord, newName, newAntal);
        }
        else
        {
            Console.WriteLine("Ogiltigt antal gäster.");
        }
    }
}

static void MarkeraBordLedigt(int Ledigtbord, List<(string bord, string name, int antal)> tables)
{
    ListInRow(tables);
    Console.WriteLine("Vilket bord är ledigt");
    int.TryParse(Console.ReadLine(), out Ledigtbord);
    
    
}  


while (true)
{
    Console.Clear();
    Console.Write("""
    =================================
    1. Visa alla bord
    2. Ändra bordsinformation
    3. Markera att ett bord är ledigt
    4. Avsluta programmet
    =================================
    Välj ett alternativ:
    """);
    string val = Console.ReadLine();


    if (val == "1") // Will show the list of tables 
    {
        Console.Clear();
        ListInRow(tables);

    }
    else if (val == "2")
    {
        ChangeList("", 0, "", ref tables);
    }
    else if (val == "3")
    {
        MarkeraBordLedigt();
    }

}