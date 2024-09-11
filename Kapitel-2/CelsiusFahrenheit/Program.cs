Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen i Celsius till Fahrenheit! Eller tvärtom.");
Console.WriteLine(" F/C");
bool isRunning = true;
string FOrC = Console.ReadLine().ToUpper();

if (FOrC == "F")
{
    Console.Write("Ange temperaturen i Fahrenheit: ");
    int tempFahrenheit = int.Parse(Console.ReadLine());

    double tempCelsius = (tempFahrenheit - 32) / 1.8;

    Console.WriteLine($"Temperaturen i Celsius är: {tempCelsius} .C");
    return;
}
else if (FOrC == "C")
{
    
    while (isRunning == true) 
    {
        Console.Write("Ange temperaturen i Celsius: ");
        int tempCelsius = int.Parse(Console.ReadLine());

        double tempFahrenheit = tempCelsius * 1.8 + 32;

        Console.WriteLine($"Temperaturen i Fahrenheit är: {tempFahrenheit} .F");
        
        
        Console.WriteLine("Vill du fortsätta? J/N");

        string answer = Console.ReadLine().ToUpper();
        
        if (answer == "N")
        {
            isRunning = false;
        }
        
}

}
else
{
    Console.WriteLine("Felaktig inmatning, kör programet igen!");
    return;
}