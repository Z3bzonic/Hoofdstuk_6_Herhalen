using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task0
    {
        public void PrimeCalculator()
        {
            Helper helper = new Helper();
            int input = helper.InputUser();
                for (int i = input - 1; i > 1; i--)
                {
                    if (i%2 != 0 && i%3 != 0 && i%5 != 0 && i%7 !=0 && i%9 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            Console.WriteLine("3 2");
        }
    }
}
