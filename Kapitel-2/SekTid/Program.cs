Console.Clear();
Console.WriteLine("Tid omvandlare, som kommer att ta tiden ");

Console.Write("Skriv in antal sekunder: ");
int totalSeconds = int.Parse(Console.ReadLine());

int timmar = totalSeconds / 3600;
int minuter = (totalSeconds % 3600) / 60;
int secunder = totalSeconds % 60;

Console.WriteLine($"{timmar:00}:{minuter:00}:{secunder:00}");