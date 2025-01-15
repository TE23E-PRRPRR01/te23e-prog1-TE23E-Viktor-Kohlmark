/* ***************************************** 
*               M A I N                    *
****************************************** */

var result = Addera(5, 2);
Console.WriteLine($"Resultat ett {result.Item1} och resultat två {result.Item2}");

Console.WriteLine(Vändtexten("Hej"));

Console.WriteLine(Multi(2, 5));


Console.WriteLine("Ange ett tal: ");
int nyTal = HeltalellerEj(); 
/* ***************************************** 
*             M E T O D E R                *
****************************************** */
// SKAPA METODER HÄR!

/// <summary>
/// En metod för att addera 
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static (int, int) Addera(int tal1, int tal2) // signatur 
{
    int summa = tal1 + tal2; // Matte något 
    int summaTvå = tal1 * tal2;
    return (summa, summaTvå);

}
/// <summary>
/// Vänder på texten så att hej blir jeh. Utöver det gör den så att första bokstaven alltid kommer att vara stor bokstav 
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
static string Vändtexten(string text)
{
    string omvändText = "";
    text = text.ToLower();
    for (int i = text.Length - 1; i >= 0; i--)
    {
        // +- svetsar ihop texten vid punkten i är på. 
        omvändText += text[i];
    }
    omvändText = char.ToUpper(omvändText[0]) + omvändText.Substring(1);

    return omvändText;
}

/// <summary>
/// Multiplicerar tal1 och tal2
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multi(double tal1, double tal2) // signatur 
{
    double summa = tal1 * tal2;
    return summa;
}


static int AntalISträng(char tecken, string text)
{
    int count = 0;
    for (var i = 0; i < text.Length; i++)
    {
        if (text[i] == tecken)
        {
            count++;
        }
    }
    return count;
}

// Anropa metoden minst 2 gånger
// Console.WriteLine(AntalISträng('m', "Välkommen"));

static string HeltalellerEj(float tal)
{
    string resultat;

    if (tal % 1 == 0)
    {
        resultat = "Ja";
    }
    else
    {
        resultat = "Nej";
    }
   
    return resultat;
}