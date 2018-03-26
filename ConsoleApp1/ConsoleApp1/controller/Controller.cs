using ConsoleApp1.controller.sorting;
using ConsoleApp1.model;
using ConsoleApp1.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.controller
{
    class Controller
    {
        public static void Main(String[] args)
        {
            Checker checker = new Checker();
            List<int> list = new List<int>(0);
            list.Add(2);
            list.Add(1);
            list.Add(3);

         
            View.OutputList(list);
            list = checker.sort(list, Sorting.INSERTION);
         
            View.OutputList(list);
            Console.WriteLine(4);
            Console.ReadLine();
        }
    }
}
