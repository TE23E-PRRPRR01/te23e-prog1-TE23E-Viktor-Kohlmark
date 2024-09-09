// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hej, idag ska du köra ett spel.");
Console.WriteLine("Spelet går ut på att du ska gissa ett hemligt number");
Thread.Sleep(5000);

Console.Clear();
Console.WriteLine("Gissa numret mellan 1 och 100");

Random random = new Random();
int baseNumber = random.Next(1, 101); // Det hemliga numret

int number = 0 ; 


while (number != baseNumber){

string textNumber = Console.ReadLine(); // Läs in texten 
number = int.Parse(textNumber); // Konvertera texten till ett heltal

    if (number > baseNumber)
    {
        Console.WriteLine("För högt!");  
    }
    else if (number < baseNumber)
    {
        Console.WriteLine("För lågt!");
    } 
    else 
    {
        Console.WriteLine($"Rätt svar! {number} är korrekt!");
    }
}






