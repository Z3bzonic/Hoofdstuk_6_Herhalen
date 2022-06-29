// See https://aka.ms/new-console-template for more information
using Extra_Oefening_Herhalingen;

Console.WriteLine("Geef een aantal in");
string ingaveString =Console.ReadLine();
int ingave = int.Parse(ingaveString);
int[] reeks = new int[ingave];
int counter = 0;

// Toon alle natuurlijk getallen van 1 tot n
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon alle natuurlijk getallen van 1 tot n");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < reeks.Length; i++) 
{
    reeks[i] = i+1;
    Console.Write($"{reeks[i]}|");
}
Console.WriteLine();

// Toon alle natuurlijk getallen van n tot 1
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon alle natuurlijk getallen van n tot 1");
Console.ForegroundColor = ConsoleColor.White;
for (int i = reeks.Length-1; i > -1; i--)
{
    Console.Write($"{reeks[i]}|");
}
Console.WriteLine();

// Toon alle even getallen tussen 1 en 100.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon alle even getallen tussen 1 en 100.");
Console.ForegroundColor = ConsoleColor.White;

int somEven = 0;

do
{
    if (counter%2==0)
    {
        Console.Write($"{counter}|");
        if (counter <= reeks.Length)
        {
            somEven += counter;
        }
    }
    counter++;  
}while (counter < 101);
counter=0;
Console.WriteLine();

// Toon alle oneven getallen tussen 1 en 100.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon alle oneven getallen tussen 1 en 100.");
Console.ForegroundColor = ConsoleColor.White;

int somOneven = 0;

do
{
    if (counter % 2 != 0)
    {
        Console.Write($"{counter}|");
        if (counter <= reeks.Length)
        {
            somOneven += counter;
        }
    }
    counter++;
} while (counter < 101);
counter = 0;
Console.WriteLine();

// Toon de som van alle getallen van 1 tot n (dus 1+2+3+4+…+n).
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon de som van alle getallen van 1 tot n (dus 1+2+3+4+…+n).");
Console.ForegroundColor = ConsoleColor.White;
int som = 0;
while (counter < reeks.Length+1)
{
    som += counter;
    counter++;
}
counter = 0;
Console.Write($"De som van alle getallen van n is {som}");
Console.WriteLine();

// Toon de som van alle even getallen van 1 tot n.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon de som van alle even getallen van 1 tot n.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(somEven);
Console.WriteLine();

// Toon de som van alle oneven getallen van 1 tot n.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Toon de som van alle oneven getallen van 1 tot n.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(somOneven);
Console.WriteLine();

// (PRO)Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("(PRO)Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine($"Er zijn {ingaveString.Length} digits");
Console.WriteLine();

// Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Schrijf een programma dat een ingevoerd getal als tekst uitschrijft. Als de gebruiker dus 123 invoert zal de uitvoer zijn: honderd drie en twintig.");
Console.ForegroundColor = ConsoleColor.White;

int[] naarLetterReeks = new int[ingaveString.Length];
int ingaveKopie =ingave;

for (int i = 0; i < ingaveString.Length; i++)
{
        naarLetterReeks[i] = ingaveKopie%10;
        ingaveKopie /= 10;
}

if (naarLetterReeks.Length == 4)
{
    if (naarLetterReeks[3] != 1)
    {
        Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[3])}{CijferInTekst.duizend}");
    }
    else
    {
        Console.Write($"{CijferInTekst.duizend}");
    }
    if (naarLetterReeks[2] != 1)
    {
        Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[2])}{CijferInTekst.honderd}");
    }
    else
    {
        Console.Write($"{CijferInTekst.duizend}");
    }
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[0])}ën");
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[1]+20)}.");
}
else if (naarLetterReeks.Length == 3)   
    {
    if (naarLetterReeks[2] != 1)
    {
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[2])}{CijferInTekst.honderd}");
    }
    else
    {
        Console.Write($"{CijferInTekst.honderd}");
    }
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[0])}ën");
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[1] + 20)}.");

}
else if (naarLetterReeks.Length == 2)
{
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[0])}ën");
    Console.Write($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[1] + 20)}.");
}
else if (naarLetterReeks.Length == 1)
{
    Console.WriteLine($"{Enum.GetName(typeof(CijferInTekst), naarLetterReeks[0])}.");
}
Console.WriteLine();
// later nog eens op terugkeren om te zorgen dat met index verschuiving alles correcter aangeroepen wordt.


//Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot n (tip: char c = Convert.ToChar(65); zal hoofdletter A tonen).
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Schrijf een programma dat alle ascii karakters en hun waarde toont van 10 tot n (tip: char c = Convert.ToChar(65); zal hoofdletter A tonen).");
Console.ForegroundColor = ConsoleColor.White;

