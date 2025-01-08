/* *********************************************
***                M A I N                   ***
********************************************* */

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("Johnny");
KvadreraTal(10); 

/* *********************************************
***               M E T O D E R              ***
********************************************* */
/// <summary>
/// 
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}

static void KvadreraTal(int tal) {
    Console.WriteLine($"{{tal} i kvadrat är {tal*tal}}");
}