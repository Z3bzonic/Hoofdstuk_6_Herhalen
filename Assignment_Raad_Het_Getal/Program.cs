// See https://aka.ms/new-console-template for more information
int getal;
int poging = 0;
int aantalPogingen = 0;
int onderGrens= 0; //deel2
int bovenGrens= 100; //deel2
int maxPogingen= bovenGrens; // deel4
string pogingString;
bool gevonden = false;
Random rand = new Random();
getal = rand.Next(0, bovenGrens);//deel4

while (!gevonden)
{
    aantalPogingen++;
    Console.WriteLine($"Geef een getal tussen {onderGrens} en {bovenGrens}"); // deel2
    pogingString = Console.ReadLine();
    poging = int.Parse(pogingString);
    if ((poging >= onderGrens) && (poging <= bovenGrens))// deel3&4
    {

    if (getal > poging)
    {
        onderGrens = poging;//deel2
        Console.WriteLine($"Het gezochte getal is groter, probeer opnieuw.");
        maxPogingen = (bovenGrens - onderGrens); //deel4
        Console.WriteLine($"Nog {maxPogingen} over");//deel4
    }
    else if (getal < poging)
    {
        bovenGrens = poging;//deel2
        Console.WriteLine($"Het gezochte getal is kleiner, probeer opnieuw.");
        maxPogingen = (bovenGrens - onderGrens); //deel4
        Console.WriteLine($"Nog {maxPogingen} over");//deel4
    }
    else
        gevonden = true;
    }
}
Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");