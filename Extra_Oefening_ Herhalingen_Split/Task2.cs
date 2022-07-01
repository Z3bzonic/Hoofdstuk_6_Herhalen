using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task2
    {
        public void MultiplicationAndUneven() 
        {
            const int vdabNumber = 100;

            for (int i = 0; i < vdabNumber+1; i++)
            {
                if (i%2 != 0 && i%3 ==0)
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
    }
}
