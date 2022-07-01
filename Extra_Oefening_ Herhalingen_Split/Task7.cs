using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Oefening__Herhalingen_Split
{
    internal class Task7
    {
        public void Average() 
        {
            Helper helper = new Helper();
            List<int> list = new List<int>();
            do
            {
                list.Add(helper.InputUser());
                if (list.Contains(-1))
                {
                    list.Remove(-1);
                    break;
                }
            } while (true);
            var sum = list.Sum();
        Console.Write($"\n{sum} / {list.Count} = {sum/list.Count}");

        }
    }
}
