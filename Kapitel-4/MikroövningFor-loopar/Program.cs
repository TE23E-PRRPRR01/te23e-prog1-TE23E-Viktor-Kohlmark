using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

Console.Clear();

static void ettTilltio(int startnumer, int slutnumer, int sum)
{
    while (true)
    {
        Console.Write("Start nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out startnumer);

        Console.Write("Slut nummer: ");
        bool max = int.TryParse(Console.ReadLine(), out slutnumer);

        if (min && max && startnumer < slutnumer)
        {

            for (int i = startnumer; i < slutnumer; i++)
            {

                Console.WriteLine(i + 1);

            }

            break;
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }
}

Console.Clear();

static void summanavtalen(int startnumer, int slutnumer, int sum)
{
    while (true)
    {

        Console.Write("Start nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out startnumer);

        Console.Write("Slut nummer: ");
        bool max = int.TryParse(Console.ReadLine(), out slutnumer);

        if (min && max && startnumer < slutnumer)
        {


            for (int i = startnumer; i < slutnumer + 1; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Summan av värderna {startnumer} och {slutnumer} är {sum}");

            break;
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }
}

static void uddaTal(int startnumer, int slutnumer, int sum)
{
    while (true)
    {

        Console.Write("Start nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out startnumer);

        Console.Write("Slut nummer: ");
        bool max = int.TryParse(Console.ReadLine(), out slutnumer);

        if (min && max && startnumer < slutnumer)
        {

            Console.WriteLine("Udda tal:");
            for (int i = startnumer; i <= slutnumer; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Jämna tal:");
            for (int i = startnumer; i <= slutnumer; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            break;
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }
}


static void Multiplikationstabell(int startnumer, int slutnumer, int sum)
{
    while (true)
    {
        Console.Write("Start nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out startnumer);

        if (min)
        {

            for (int i = 0; i < 11; i++)
            {
                sum = startnumer * i;
                Console.WriteLine($"{startnumer} * {i} = {sum}");

            }

            break;
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }
}

static void Sjänor(int startnumer, int slutnumer, int sum)
{
    while (true)
    {
        Console.Write("Slut nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out slutnumer);

            for (int i = 0; i < slutnumer+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            break;
    }
}

static void Julgran(int startnumer, int slutnumer, int sum)
{
    while (true)
    {
        Console.Write("Slut nummer: ");
        bool min = int.TryParse(Console.ReadLine(), out slutnumer);



            break;
    }
}

while (true)
{
    Console.Write("""

    1. Tal
    2. Summan av talen  
    3. Skriv ut udda sifror 
    4. Multiplikationstabell
    5. Skapa ett mönster med stjärnor
    6. Julgran 
    ==================
    Val:
    """);

    string answer = Console.ReadLine();
    if (answer == "1")
    {
        ettTilltio(0, 0, 0);
    }
    else if (answer == "2")
    {
        summanavtalen(0, 0, 0);
    }
    else if (answer == "3")
    {
        uddaTal(0, 0, 0);
    }
    else if (answer == "4")
    {
        Multiplikationstabell(0, 0, 0);
    }
    else if (answer == "5")
    {
        Sjänor(0, 0, 0);
    }
    else if (answer == "6") 
    {
        Julgran(0,0,0);
    }
    else
    {
        Console.WriteLine("Fel!");
    }
}
