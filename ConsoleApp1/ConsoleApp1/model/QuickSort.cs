using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model.sorting
{
    class QuickSort
    {
        public static List<int> quickSort(List<int> array)
        {
            int startIndex = 0;
            int endIndex = array.Count - 1;
            doSort(array, startIndex, endIndex);
            return array;
        }

        private static void doSort(List<int> array, int start, int end)
        {
            if (start >= end)
                return;
            int i = start, j = end;
            int cur = i - (i - j) / 2;
            while (i < j)
            {
                while (i < cur && (array.ElementAt(i) <= array.ElementAt(i)))
                {
                    i++;
                }
                while (j > cur && (array.ElementAt(cur) <= array.ElementAt(j)))
                {
                    j--;
                }
                if (i < j)
                {
                    int help = array.ElementAt(i);
                    array[i]= array.ElementAt(j);
                    array[j]=  help;
                    
                    if (i == cur)
                        cur = j;
                    else if (j == cur)
                        cur = i;
                }
            }
            doSort(array, start, cur);
            doSort(array, cur + 1, end);
        }
    }
}
