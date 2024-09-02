using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("You are walking down a dark alley. On the left, you have a path leading to the water channel, and on the right, the train station.");
        string answer = Console.ReadLine();

        if (answer == "left")
        {
            Console.WriteLine("You walk down the path and see a stray cat walking above you on a small catwalk. The catwalk continues far down the path.");
            Console.WriteLine("At the end of the path, there is a small boat.");
            Console.WriteLine("What do you do? Pet the cat or jump in the boat? Answer 'pet cat' or 'jump in boat'.");
            answer = Console.ReadLine();

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
        else if (answer == "right")
        {
            Console.WriteLine("You go to the train station, and there are two trains on the platform.");
            Console.WriteLine("(1) Goes to Ijnsd");
            Console.WriteLine("(2) Goes to Anj F");
            Console.WriteLine("Choose between 1 or 2");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("You board the train to Ijnsd.");
                // Add your logic for what happens next when choosing train 1
            }
            else if (answer == "2")
            {
                Console.WriteLine("You board the train to Anj F.");
                // Add your logic for what happens next when choosing train 2
            }
            else
            {
                Console.WriteLine("Invalid answer. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid answer. Please try again.");
        }
    }
}