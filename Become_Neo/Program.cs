// See https://aka.ms/new-console-template for more information
Random rangen = new Random();
Console.ForegroundColor = ConsoleColor.Green;
List<char> generated = new List<char>();
int genCount = 0;

while (true)
{
    //Genereer nieuw random teken:
    char teken = Convert.ToChar(rangen.Next(62, 400));
    genCount++;
    if (genCount == 5000)
    {
        generated.Clear();
    }
    generated.Add(teken);

    //Ietwat vertragen
    //System.Threading.Thread.Sleep(5); //dit getal is in milliseconden. Speel er gerust mee.

    //Af en toe donker kleurtje
    int choice = rangen.Next(0, 13);
    if (choice >= 0 && choice <4)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(30, 10);
        foreach (var item in generated)
        {
            Console.Write(item);
        }
    }
    if (choice >= 4 && choice < 8)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(20, 40);
        foreach (var item in generated)
        {
            Console.Write(item);
        }
    }
    if (choice >= 8 && choice < 12)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(20, 0);
        foreach (var item in generated)
        {
            Console.Write(item);
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 0);
        foreach (var item in generated)
        {
            Console.Write(item);
        }
    }
}