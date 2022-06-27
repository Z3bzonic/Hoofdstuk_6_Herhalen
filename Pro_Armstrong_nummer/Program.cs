// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef een getal in om te weten of het een Armstrong nummer betreft");
Console.WriteLine();
string invoerInString = "";

invoerInString = Console.ReadLine();
int tel = invoerInString.Length;
int invoer = int.Parse(invoerInString);
int invoerKeeper = invoer;
int[] cijfer = new int[tel+1];
int[] cijferMacht = new int[tel+1];
int remainder = 0;
int vergelijking = 0;


for (int i = 0; i < tel+1; i++)
{
    cijfer[i] = invoer%10;
    invoer = invoer/10;
}
int pos=0;
foreach (var item in cijfer)
{
    cijferMacht[pos] = (int)Math.Pow(item, tel);
    pos++;  
}
foreach (var item in cijferMacht)
{
    vergelijking = vergelijking + item;
}

for (int i = 0; i < tel+1; i++)
{
    Console.Write($"{cijfer[i]} ^{tel} = {cijferMacht[i]} en ");
}

if (vergelijking.Equals(invoerKeeper))
{
    Console.WriteLine();
    Console.Write(invoerKeeper);
    Console.WriteLine(@"
▀▀   ▄▀█ █▀█ █▀▄▀█ █▀ ▀█▀ █▀█ █▀█ █▄░█ █▀▀   █▄░█ █░█ █▀▄▀█ █▄▄ █▀▀ █▀█
▀▀   █▀█ █▀▄ █░▀░█ ▄█ ░█░ █▀▄ █▄█ █░▀█ █▄█   █░▀█ █▄█ █░▀░█ █▄█ ██▄ █▀▄");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Het getal is een gewoon getal");
}

