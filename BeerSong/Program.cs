// See https://aka.ms/new-console-template for more information
int counter;

while (true)
{
    for (counter = 99; counter > 0; counter--)
    {
        Console.WriteLine($"{counter} bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more.");
        Console.ReadLine();
    }
    Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more.");
}

