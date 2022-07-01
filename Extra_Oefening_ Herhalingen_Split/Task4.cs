using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task4
    {
        public void MultiplicationOfTenByInput()
        {
        Helper helper = new Helper();
        int input = helper.InputUser();

            for (int i = 1; i < input+1; i++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Console.Write($"{i}*{y} = {i*y} en ");
                }
                Console.WriteLine();
            }

        }
    }
}
