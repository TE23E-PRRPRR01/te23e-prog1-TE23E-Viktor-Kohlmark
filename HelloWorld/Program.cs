Console.Clear();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Nu mitt första c# pogram");
Console.WriteLine("Jag är en konsol applikation");
Console.Write("Vad heter du? ");
string namn = Console.ReadLine() ?? "";
Console.WriteLine("Hej " + namn);
Console.Write("Vad gör du på fritiden? ");
string fritid = Console.ReadLine() ?? "";
Console.WriteLine("Jag med, " + fritid + " är kul");

Console.ResetColor();

Console.WriteLine("Nu har jag ändrat färg på bakgrund och text");
Console.WriteLine("Vad var det bästa med OS 2024 i Paris, då de spelade under Efieltornet? ");
string os = Console.ReadLine() ?? "";
Console.WriteLine("Ja, " + os + " var det bästa med OS 2024");