// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<double> negGetal = new List<double>();
List<double> posGetal = new List<double>();
List<double> allGetal = new List<double>();
double somNeg= 0;
double somPos= 0;
double gemiddelde = 0;
double invoerConvert = 0;
string keuze = "";

do
{
    Console.WriteLine($"U voerde : €{Math.Round(invoerConvert, 2)} in");
    Console.WriteLine($"Het lopende gemiddelde is {Math.Round(gemiddelde, 2)}");
    Console.WriteLine($"========Som negatieve======som positieve========");
    Console.WriteLine($"=======  {Math.Round(somNeg, 2)}  ==========  {Math.Round(somPos, 2)}  =======");
    Console.WriteLine("Druk he volgende getal in, enter voor update en x om te stoppen");
    keuze = Console.ReadLine();
    if (keuze == "x")
    {
        return;
    }
    invoerConvert = Convert.ToDouble(keuze);

    if (invoerConvert < 0)
    {
        negGetal.Add(invoerConvert);
        somNeg = somNeg + invoerConvert;
        allGetal.Add(invoerConvert);
    }

    if (invoerConvert > 0)
    {
        posGetal.Add(invoerConvert);
        somPos = somPos + invoerConvert;
        allGetal.Add(invoerConvert);
    }
    gemiddelde = Math.Round((somNeg + somPos) / allGetal.Count, 2);
    Console.Clear();

} while (keuze != "X");