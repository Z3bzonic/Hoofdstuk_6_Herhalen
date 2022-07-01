using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Helper
    {
        public int InputUser()
        {
            Console.WriteLine("Geef een getal in");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public void StartMessage(string selector)
        {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{selector}");
                SetColorToDefault();
        }
        public void SetColorToDefault() 
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public int ChoiceSave(int choice) 
        {
            return choice;
        }
}
}
