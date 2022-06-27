// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef het cijfer om de vermenigvuldigingstafel van te genereren");

int keuze = 0;
bool isCijfer = false;
int[] uitkomsten = new int[10];
do
{
    isCijfer = int.TryParse(Console.ReadLine(), out keuze);
    if (isCijfer=true)
    {
        for (int i = 1; i < 10; i++)
        {
            uitkomsten[i-1] = keuze * i;
        }
        foreach (var item in uitkomsten)
        {
            int i = 1;
            Console.WriteLine($"{keuze} * {i} = {item}");
            i++;
        }
    }
    Array.Clear(uitkomsten, 0, 10);
    //debug
    Console.WriteLine(isCijfer);
    // einde debug
} while ((keuze != 0)&&(isCijfer=true));

if (isCijfer == false)
{
    Console.WriteLine("ongeldige invoer, exiting");
}
else
{
    Console.WriteLine("0 gekozen, exiting");
}

// ik krijg ALTIJD "0 gekozen, exiting" de reden is dat isCijfer altijd true word..
// ook bij een ingave zoals 40,g waarmee ik probeerde vermijden
// dat die mss een charconversie deed op de achtergrond
// what's going on!?