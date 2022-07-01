using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task1
    {
        public void FibonacciToInput()
        {
            Helper helper = new Helper();
            int input = helper.InputUser();
            int sum = 0;
            int previous = 0;
            int next = 1;
            do
            {
                sum = previous+next;
                previous=next;
                next = sum;
                Console.Write($"{sum} ");
                input--;
            } while (input > 0);


        }
    }
}
