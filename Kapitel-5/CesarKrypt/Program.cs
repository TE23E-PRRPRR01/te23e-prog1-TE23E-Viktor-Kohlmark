// Program för att kryptera och dekryptera cesarkrypt 
bool main = true;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Ceasar-krypto: Kryptera ett ord.");

while (main)
{
    Console.WriteLine();

    Console.WriteLine(
    """
    1. Encryptera 
    2. Decryptera 
    3. Avsluta 
    """);

    Console.Write("Svar : ");
    string answer = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine("------------");


    if (answer == "1")
    {
        Console.WriteLine("Skriv in antingen ett kodat meddelande eller klarspråk");
        Console.Write("Ange ett ord: ");

        string ord = Console.ReadLine().ToUpper();
        string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
        string krypteradText = "";

        Console.Write("Ange en nyckel (1-9): ");
        int nyckel = int.Parse(Console.ReadLine());

        // Loopa igenom varje bokstav i ordet
        foreach (char bokstav in ord)
        {
            int index = alfabet.IndexOf(bokstav);
            if (index != -1)
            {
                // Lägg till nyckeln och använd modulus för att hantera omslag
                int nyPosition = (index + nyckel) % alfabet.Length;

                // Plocka ut det nya tecknet
                char krypteradBokstav = alfabet[nyPosition];
                krypteradText += krypteradBokstav;
            }
            
        }
        Console.WriteLine("----------------");
        Console.WriteLine($" Ditt ord är : {krypteradText}");
        Console.WriteLine("----------------");
    }

    else if (answer == "2" )
    {
        Console.WriteLine("Skriv in antingen ett kodat meddelande eller klarspråk");
        Console.Write("Ange ett ord: ");

        string ord = Console.ReadLine().ToUpper();
        string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
        string krypteradText = "";

        Console.Write("Ange en nyckel (1-9): ");
        int nyckel = int.Parse(Console.ReadLine());

        // Loopa igenom varje bokstav i ordet
        foreach (char bokstav in ord)
        {
            int index = alfabet.IndexOf(bokstav);
            if (index != -1)
            {
                // Lägg till nyckeln och använd modulus för att hantera omslag
                int nyPosition = (index - nyckel + alfabet.Length) % alfabet.Length;

                // Plocka ut det nya tecknet
                char krypteradBokstav = alfabet[nyPosition];
                krypteradText += krypteradBokstav;
            }
            else 
            {
                Console.WriteLine("Felaktigt svar, försök igen");
            }
        }
        Console.WriteLine("----------------");
        Console.WriteLine($" Ditt ord är : {krypteradText}");
        Console.WriteLine("----------------");
    }
    else if (answer == "3")
    {
        main = false;
    }
    else
    {
        Console.WriteLine("Felaktigt svar, försök igen");
    }
}
