using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.controller.sorting
{
    class Choice
    {
        public static List<int> SelectionSort(List<int> numbers)
        {
            int min,help;

            for (int index = 0; index < numbers.Count - 1; index++)
            {
                min = index;
                for (int scan = index + 1; scan < numbers.Count; scan++)
                {
                    if (numbers.ElementAt(scan) < numbers.ElementAt(min))
                        min = scan;
                }
                 help = numbers.ElementAt(index);
                numbers[index] =  numbers.ElementAt(min);
                numbers[min]=  help;
          
            }
            return numbers;
        }
    }
}
