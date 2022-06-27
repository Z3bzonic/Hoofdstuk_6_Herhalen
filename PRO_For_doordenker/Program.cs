// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef de driehoekbreedte in!");
int invoer = int.Parse(Console.ReadLine());
string teken = "*";



Console.Write(teken);
Console.Write("\n");

for (int i = 0; i < (invoer / 4); i++)
{
    Console.Write(teken);
}
Console.Write("\n");

for (int i = 0; i < (invoer / 2); i++)
{
    Console.Write(teken);
}
Console.Write("\n");

for (int i = 0; i < (invoer); i++)
{
    Console.Write(teken);
}
Console.Write("\n");

for (int i = 0; i < (invoer / 2); i++)
{
    Console.Write(teken);
}
Console.Write("\n");

for (int i = 0; i < (invoer / 4); i++)
{
    Console.Write(teken);
}
Console.Write("\n");

    Console.Write(teken);