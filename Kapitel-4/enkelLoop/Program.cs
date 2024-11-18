using System.Runtime.Intrinsics.Arm;
Console.Clear();

static void enkelString(string namn, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine((i + 1) + "" + namn);
    }
}

static void enkelStringMedNumer(string namn, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine((i + 1) + "" + namn);
    }
}

static void inputEnkelString(string namn, int antal)
{
    while (true)
    {
        Console.Write("Skriv in namn: ");
        namn = Console.ReadLine();
        Console.Write("Skriv in antal: ");
        int.TryParse(Console.ReadLine(), out antal);

        if (antal > 1 && antal < 10)
        {

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine((i + 1) + " " + namn);
            }

            antal = antal * 2;
            Console.WriteLine("Antal * 2 = " + antal);
            antal = antal / 2;
            Console.WriteLine("Antal / 2 =" + antal);
            antal = antal + 2;
            Console.WriteLine("Antal + 2 =" + antal);
            antal = antal - 2;
            Console.WriteLine("Antal -2 =" + antal);


            break;
        }
    }
}

Console.Write("""
Meny 
1. Skriv ut namn
2. Skriv ut namn med numer 
3. Lit användaren bestäma antalet repetitioner
Skriv in ditt val: 
""");

string answer = Console.ReadLine();
if (answer == "1")
{
    enkelString("Axel B", 5);
}
else if (answer == "2")
{
    enkelStringMedNumer("Axel B", 5);
}
else if (answer == "3")
{
    inputEnkelString("Axel B", 5);
}
else
{
    Console.WriteLine("Felaktigt val");
}