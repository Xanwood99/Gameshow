using Microsoft.VisualBasic;

int points = 0;

Console.WriteLine("Hej och välkommen till Derins frågesport");

Console.WriteLine("1. Hur lång var en Yutyrannus?");
Console.WriteLine(" a) 9m b) 4m c) 14m");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
    points++;
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}

Console.WriteLine("2. Vad är yutyrannus?");
Console.WriteLine(" a) Gräsätare b) Köttätare c) fiskätare");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
    points++;
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}
Console.WriteLine("vilken tidsperiod levde yutyrannus i?");
Console.WriteLine(" a) Krita b) Jura c) Trias");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
    points++;
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("INCORRECT");
}
    
Console.WriteLine("Du fick "+points+" poäng.");
if (points == 0)
{
    Console.WriteLine("Du kan inget om Yutyrannus >:( )");  
} 
else if (points < 3)
{
    Console.WriteLine("Du kan ändå mycket om Yutyrannus eller så fick du iallafall mer än 0 pöäng!");
}
Console.ReadLine();
