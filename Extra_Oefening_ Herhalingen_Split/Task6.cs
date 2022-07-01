using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task6
    {
        public void SerieSum() 
        {
        Helper helper = new Helper();
            int input = helper.InputUser();
            float sum = 0;
            float[] nines = new float[input];
            nines[0] = 9.0F;

            for (int i = 1; i < nines.Length; i++)
            {
                nines[i] = nines[i-1] + 0.9F;
                nines[i] *= 10;
            }
            foreach (var item in nines)
            {
                sum += item;
                Console.Write($"{item} + ");
            }
            Console.WriteLine($" = {sum}");
        }
    }
}
