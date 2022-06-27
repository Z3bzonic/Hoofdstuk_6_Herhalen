// See https://aka.ms/new-console-template for more information

char invoer;
string rna = "";

do {
    Console.WriteLine("Geef een nucleotideletter op");
    char.TryParse(Console.ReadLine(), out invoer);
    switch (invoer)
    {
        case 'g':
        case 'G':
            invoer = 'C';
            break;
        case 'c':
        case 'C':
            invoer = 'G';
            break;
        case 't':
        case 'T':
            invoer = 'A';
            break;
        case 'a':
        case 'A':
            invoer = 'U';
            break;
        default:
            break;
    }
    rna += invoer;
    Console.Write($"{rna} + ");
} while (invoer == 'G' || invoer == 'C' || invoer == 'T' || invoer == 'A' || invoer == 'g' || invoer == 'c' || invoer == 't' || invoer == 'a' || invoer == 'U');

// in hindsight had ik beter geen do while gebruikt omdat ELKE mogelijkheid van de switch case ook moet herhaald worden
// indien je BV U niet specifieert zal de A onthouden worden en wordt de input overgeslagen
// lijkt me een bug?? maar kan het niet oplossen door een waarde reset want de invoer
// MOET dan voorkomen in de while en zo kan je U als foute invoer doen