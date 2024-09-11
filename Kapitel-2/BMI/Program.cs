Console.Clear();

Console.WriteLine("Hej, programet kommer att kolla din BMI");

Console.WriteLine("Skriv in din längd i meter: ");
double meter = double.Parse(Console.ReadLine());

Console.WriteLine("Skriv  din   vikt  i Kg: ");
double vikt = double.Parse(Console.ReadLine());

double bmi = vikt / (meter * meter);
bmi = Math.Round(bmi, 2);

Console.WriteLine($"Din BMI är: {bmi}");