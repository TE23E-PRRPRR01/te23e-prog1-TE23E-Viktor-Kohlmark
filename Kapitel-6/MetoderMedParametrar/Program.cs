/*  *******************************************************************************
    *                                   M A I N                                   *
    *******************************************************************************
*/

Console.Clear();

// SkiVertikalt("Måndag");

/// <summary>
/// 
/// </summary>
/// <param name="medelande"></param>


static void SkiVertikalt(string medelande)
{
    for (var i = 0; i < medelande.Length; i++)
    {
        Console.WriteLine(medelande[i]);
    }
}


/*  *******************************************************************************
    *                                 P A K E T                                   *
    *******************************************************************************
*/

SIGMAkvadrat(4);
/// <summary>
/// 
/// </summary>
/// <param name="sida"></param>
static void SIGMAkvadrat(int sida)
{
    for (var i = 0; i < sida; i++)
    {
        for (var j = 0; j < sida; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

UpprepaTect("Sigma boy", 20);
UpprepaTect("Hejsan", 5);
/// <summary>
/// 
/// </summary>
/// <param name="text"></param>
/// <param name="antal"></param>
static void UpprepaTect(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}


/*  *******************************************************************************
    *                           T E M P E R A T U R                               *
    *******************************************************************************
*/

CTillF(22);
/// <summary>
/// 
/// </summary>
/// <param name="c"></param>

static void CTillF(int c)
{
    Console.WriteLine((c * 9 / 5 + 32) + ".f");
}


FTillC(71);

/// <summary>
/// 
/// </summary>
/// <param name="f"></param>

static void FTillC(int f)
{
    Console.WriteLine(((f - 32) * 5 / 9) + ".c");
}

SlumpTal(5);

/// <summary>
/// Skriver ut ett slumptal mellan 0 och maxvärdet (exklusivt).
/// </summary>
/// <param name="max"></param>
static void SlumpTal(int max)
{
    for (var i = 0; i < max; i++)
    {
        Console.WriteLine(new Random().Next(1, 7));
    }
}