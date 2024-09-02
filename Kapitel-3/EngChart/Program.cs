// Program som simulerar kända Engineering Flowchart 
using System.Globalization;

Console.Clear();
Console.WriteLine("Välkomen till ingenjörens flödesschema");

Console.WriteLine(@"
    *  / \_ *  / \_      _  *        *   /\'__        *
      /    \  /    \,   ((        .    _/  /  \  *'.
 .   /\/\  /\/ :' __ \_  `          _^/  ^/    `--.
    /    \/  \  _/  \-'\      *    /.' ^_   \_   .'\  *
  /\  .-   `. \/     \ /==~=-=~=-=-;.  _/ \ -. `_/   \
 /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-
/jgs     `.  / /       `.~-^=-=~=^=.-'      '-._ `._");


Console.WriteLine("Dose it move?");
Console.WriteLine("Y & n");
string? answer = Console.ReadLine();

if (answer == "Y") 
{
    Console.WriteLine("Should it? Y & n ");
    answer = Console.ReadLine(); 
    if (answer == "Y")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Plz use Duct tape");
    }
} 
else if (answer == "n")
{
    Console.WriteLine("N");
    Console.WriteLine("Should it? Y & n ");
    answer = Console.ReadLine(); 
    if (answer == "Y")
    {
        Console.WriteLine("Use WD-40");
    }
    else
    {
        Console.WriteLine("No problem! ");
    }
}
else 
{
 Console.WriteLine("Faild Input");
}