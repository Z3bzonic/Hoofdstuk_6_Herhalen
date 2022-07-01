using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task5
    {
        public void HarmonicCalculator()
        {
            Helper helper = new Helper();
            float input = helper.InputUser();
            float sum = 0;

            for (float i = 1; i < input + 1; i++)
            {
                Console.Write($"1/{i} + som {sum} en ");
                sum = sum + (1 / i);
            }
            Console.WriteLine($"som = {Math.Round(sum, 2)}");
        }
    }
}
