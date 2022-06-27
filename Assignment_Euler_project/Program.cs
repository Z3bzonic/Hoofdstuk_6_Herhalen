// See https://aka.ms/new-console-template for more information

List <int> cijferReeks = new List<int> ();
int som=0;

for (int i = 0; i < 10001; i++)
{
    if ((i % 3)== 0 || (i % 5) == 0)
    {
        cijferReeks.Add(i);       
    }

}

foreach (var item in cijferReeks)
{
    som = som + item;
    Console.Write($"{item} +");
    if (som == 234168)
    {
        break;
    }
}
Console.WriteLine();
Console.WriteLine($"{som} is de uitkomst");