List<(string app, int age)> 
apps = new List<(string, int)>
{
    ("Roblox", 10),
    ("Tiktok", 20),
    ("Facebook", 30),
    ("MinaSidor", 40),
    ("Discord", 50),
    ("Mincraft", 60),
    ("Spotify", 70),
    ("Netflix", 80),
    ("Youtube", 90),
    ("Google", 100)
};

Console.Clear();
Console.Write("Kan du skriva din ålder?");

int age = int.Parse(Console.ReadLine());

foreach (var app in apps) {
    if (age >= app.age) {
        Console.WriteLine($"Du är {age} år gammal och kan använda {app.app}");
    }
}