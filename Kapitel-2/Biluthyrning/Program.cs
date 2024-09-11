int startFee = 500;
int costPerMil = 5;
int costPerDay = 100;

Console.WriteLine("Välkommen till Biluthyrningen!");
Console.WriteLine("Ange antal mil du vill köra:");

int mil = int.Parse(Console.ReadLine());

Console.WriteLine("Ange antal dagar du vill hyra bilen:");

int days = int.Parse(Console.ReadLine());
int totalCost = startFee + (mil * costPerMil) + (days * costPerDay);// 

Console.WriteLine($"Total kostnad för att hyra bilen: {totalCost} kr");
