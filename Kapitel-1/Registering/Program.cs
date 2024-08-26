Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Program för att registera förnamn och efternamn");

Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();

Console.WriteLine($"Du har angett förnamn: {förnamn} och efternamn: {efternamn}");

