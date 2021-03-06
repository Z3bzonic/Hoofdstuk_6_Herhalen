// See https://aka.ms/new-console-template for more information
using Assignment_Steen_Schaar_Papier;

int scoreComputer = 0;
int scoreSpeler = 0;
int pogingen = 0;
Random dice = new Random();
int wapen= 0;
int computerKeuze = 0;

while ((scoreComputer < 11) && (scoreSpeler < 11))
{
    Console.WriteLine("Kies Blad(0), steen(1) of schaar (2)");
    wapen = int.Parse(Console.ReadLine());
    computerKeuze = dice.Next(0, 2);
    if (wapen != computerKeuze)
    {
        switch (wapen)
        {
            case 0:
                if (computerKeuze == 1)
                {
                    Console.WriteLine($"Speler wint met {Wapens.Blad}");
                    scoreSpeler++;
                }
                else
                {
                    Console.WriteLine($"Computer wint met {Wapens.Schaar}");
                    scoreComputer++;
                }
                break;
            case 1:
                if (computerKeuze == 2)
                {
                    Console.WriteLine($"Speler wint met {Wapens.Steen}");
                    scoreSpeler++;
                }
                else
                {
                    Console.WriteLine($"Computer wint met {Wapens.Blad}");
                    scoreComputer++;
                }
                break;
            case 2:
                if (computerKeuze == 0)
                {
                    Console.WriteLine($"Speler wint met {Wapens.Schaar}");
                    scoreSpeler++;
                }
                else
                {
                    Console.WriteLine($"Computer wint met {Wapens.Steen}");
                    scoreComputer++;
                }
                break;
            default:
                break;
        }

    }
    else
    {
        Console.WriteLine("Gelijkspel! Opnieuw");

    }
    pogingen++;
    Console.WriteLine($"Computerscore: {scoreComputer} ");
    Console.Write($"Spelerscore : {scoreSpeler} ");
    Console.WriteLine();
}

if (scoreSpeler > scoreComputer)
{
    Console.WriteLine();
    Console.WriteLine($"De speler is gewonnen met {scoreSpeler}");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine($"De computer is gewonnen met {scoreComputer}");
    Console.WriteLine();
}