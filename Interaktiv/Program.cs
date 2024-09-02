using System.Runtime.CompilerServices;
using System.Xml.Serialization;

Console.WriteLine("Du står utanför ett casino. Vill du gå in Ja/Nej");

string val = Console.ReadLine();

if (val.ToLower() == "ja")
{
    Console.WriteLine("Rätt svar!");

    Console.WriteLine("Vill du lägga alla dina pengar på Roulette Ja/Nej");
    val = Console.ReadLine();

if (val.ToLower() == "ja")
{
    Console.WriteLine("Rätt svar!");

    Console.WriteLine("Svart eller Rött");
    val = Console.ReadLine();

if (val.ToLower() == "svart")
{
    Console.WriteLine("Grattis du förlora allt");
    Console.ReadLine();
}
else if (val.ToLower() == "rött")
{
    Console.WriteLine("Grattis! Du är milijonär");
    Console.ReadLine();
}
}
else if (val.ToLower() == "nej")
{
    Console.WriteLine("FEL SVAR!");   
    Console.ReadLine();
}
}
else if (val.ToLower() == "nej")
{
    Console.WriteLine("FEL SVAR!");   
    Console.ReadLine();
}
