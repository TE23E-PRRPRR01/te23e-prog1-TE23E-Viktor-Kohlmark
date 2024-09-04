Console.Clear();

Console.WriteLine("Welcome to the game!");
Console.WriteLine("You are walking down a dark alley. On the left, you have a path leading to the water channel, and on the right, the train station.");
string answer = Console.ReadLine()
if (answer == "left")
{
    Console.WriteLine("You walk down the path and see a stray cat walking above you on a small catwalk. The catwalk continues far down the path.");
    Console.WriteLine("At the end of the path, there is a small boat.");
    Console.WriteLine("What do you do? Pet the cat or jump in the boat? Answer 'pet cat' or 'jump in boat'.");
    answer = Console.ReadLine()
    if (answer == "pet cat")
    {
        Console.WriteLine("The cat has rabies, and you die a slow and agonizing death.");
    }
    else if (answer == "jump in boat")
    {
        Console.WriteLine("You jump in the boat and sail away to a new land.");
        Console.WriteLine("To explore new stray cats.");
    }
    else
    {
        Console.WriteLine("Invalid answer. Please try again.");
    }
}