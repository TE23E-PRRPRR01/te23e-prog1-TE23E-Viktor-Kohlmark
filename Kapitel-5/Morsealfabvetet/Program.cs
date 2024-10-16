// Morsekåd konverterare 
Console.Clear();
Console.WriteLine("Gör en morsekod app");

// Listorna programet kommer att använda 
List<string> alfabetetList = new List<string>
{
    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
    "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
    "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
};

List<string> morseList = new List<string>
{
    ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
    "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
    "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."
};

// Inslagning av de två listorna 

bool program = true; // Så länge denna är igång kör programet   

// Programet användaren kommer att påverka 
while (program)
{

    Console.WriteLine("Skriv i alfabetet för att få det i Morsekod");
    string? medelande = Console.ReadLine();

    Console.WriteLine("---------- Alfabetet till morsekod ----------");

    foreach (var bokstav in medelande)
    {
        int index = alfabetetList.IndexOf(bokstav.ToString().ToUpper());

        if (index >= 0)
        {

            string morsekod = morseList[index];
            Console.Write(morsekod);


            foreach (var signal in morsekod)
            {
                if (signal == '.')
                {
                    Console.Beep(500, 200);
                    Thread.Sleep(100);
                }
                else
                {
                    Console.Beep(500, 600);
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(100);
        }
        else
        {
            Console.WriteLine("?");
        }
        // Spela upp i ljud-beep
        // Dvs loopa igenom morsetecknet 

    }
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------");

}
