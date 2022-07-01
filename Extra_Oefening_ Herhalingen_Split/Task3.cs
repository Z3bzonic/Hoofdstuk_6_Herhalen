using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task3
    {
        public void PowerOfFive()
        {
            Helper helper = new Helper();
            int input = helper.InputUser();
            const int stupidInt = 5;
            while (input > 0)
            {
                Console.Write($"{stupidInt}tot de {input} = {Math.Pow(stupidInt, input)} en ");
                input--;
            }

        }
    }
}
