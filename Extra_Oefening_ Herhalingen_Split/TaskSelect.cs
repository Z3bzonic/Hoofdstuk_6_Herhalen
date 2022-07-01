using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class TaskSelect
    {
        public string SelectTask()
        {
            Helper helper = new Helper();
            Console.WriteLine("(0) Toon ale priemgetallen van 1 tot n.");
            Console.WriteLine("(1) Toon de reeks van Fibonacci tot n termen.");
            Console.WriteLine("(2) Toon alle getallen die een veelvoud van 3 zijn en oneven zijn tot en met 100.");
            Console.WriteLine("(3) Toon alle machten tot 5 van n.");
            Console.WriteLine("(4) Toon de tafels tot 10 van ieder getal van 1 tot en met n.");
            Console.WriteLine("(5) Schrijf een programma om de eerste n termen van een harmonische reeks te tonen en bereken vervolgens de som van deze termen.");
            Console.WriteLine("(6) Schrijf een programma dat de som van de serie 9+99+999+9999+99999+999999 berekent");
            Console.WriteLine("(7) Vraag aan de gebruiker getallen tot hij -1 invoert. Toon het gemiddelde van de ingevoerde getallen.");

            string task = Console.ReadLine();
            int choice = int.Parse(task);
            helper.ChoiceSave(choice);
            switch (task)
            {
                case "0":
                    task = "Toon ale priemgetallen van 1 tot n.";
                    Task0 subProgram0 = new Task0();
                    subProgram0.PrimeCalculator();
                    break;
                case "1": 
                    task = "Toon de reeks van Fibonacci tot n termen.";
                    Task1 subProgram1 = new Task1();
                    subProgram1.FibonacciToInput();
                    break;
                case "2": 
                    task = "Toon alle getallen die een veelvoud van 3 zijn en oneven zijn tot en met 100.";
                    Task2 subProgram2 = new Task2();
                    subProgram2.MultiplicationAndUneven();
                    break;
                case "3": 
                    task = "Toon alle machten tot 5 van n.";
                    Task3 subProgram3 = new Task3();
                    subProgram3.PowerOfFive();
                    break;
                case "4": 
                    task = "Toon de tafels tot 10 van ieder getal van 1 tot en met n.";
                    Task4 subProgram4 = new Task4();
                    subProgram4.MultiplicationOfTenByInput();
                    break;
                case "5": 
                    task = "Schrijf een programma om de eerste n termen van een harmonische reeks te tonen en bereken vervolgens de som van deze termen.";
                    Task5 subProgram5 = new Task5();
                    subProgram5.HarmonicCalculator();
                    break;
                case "6": 
                    task = "Schrijf een programma dat de som van de serie 9+99+999+9999+99999+999999 berekent";
                    Task6 subProgram6 = new Task6();
                    subProgram6.SerieSum();
                    break;
                case "7": 
                    task = "Vraag aan de gebruiker getallen tot hij -1 invoert. Toon het gemiddelde van de ingevoerde getallen.";
                    Task7 subProgram7 = new Task7();
                    subProgram7.Average();
                    break;
                default:
                    break;
            }
            return task;
        }
    }
}
