// Porgram Name: Lab 2 - C# Programming - CIS 199-75 - 28509 
Console.Clear();
Console.WriteLine("Hej, jag heter Kalle och jag är en dator. Vad heter du?");
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"Hej, {name}");

Console.WriteLine("Hur gammal är du?");
int.TryParse(Console.ReadLine(), out int age); 
Console.WriteLine($"Du är {age} år gammal.");

Console.WriteLine("Vad är din favoritfärg?");
string favColor = Console.ReadLine();

