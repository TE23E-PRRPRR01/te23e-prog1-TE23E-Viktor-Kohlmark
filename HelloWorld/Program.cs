Console.Clear();
Console.WriteLine("Skibidi, världen!");

Console.WriteLine("Nu mitt första c# program");
Console.WriteLine("Jag är en rizlerapplikation");
Console.Write("Vad heter du? ");
string namn = Console.ReadLine() ?? "";
Console.WriteLine("Skibidi " + namn);
Console.Write("Vad gör du på fritiden? ");
string fritid = Console.ReadLine() ?? "";
Console.WriteLine("Skibidi också, " + fritid + " är kul");

Console.ResetColor();

Console.WriteLine("Nu har jag ändrat färg på bakgrund och text");
Console.WriteLine("Vad var det bästa med OS 2024 i Paris, då de spelade under Eiffeltornet? ");
string os = Console.ReadLine() ?? "";
Console.WriteLine("Skibidi, " + os + " var det bästa med OS 2024");
