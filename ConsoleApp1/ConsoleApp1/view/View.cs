using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.view
{
    class View
    {
        public static void Output(String msg)
        {
            Console.WriteLine(msg);
        }

        public static void OutputList(List<int> list)
        {for (int i = 0; i< list.Count;i++)
            {
                Console.Write(list.ElementAt(i) + " ");
            }
            Console.WriteLine();

        }

    }
}
