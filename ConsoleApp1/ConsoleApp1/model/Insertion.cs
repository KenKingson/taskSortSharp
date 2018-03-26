using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model.sorting
{
    class Insertion
    {
        public static List<int> insertIntoSort(List<int> arr)
        {
            int j;
            int temp;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr.ElementAt(i) > arr.ElementAt(i + 1))
                {
                    temp = arr.ElementAt(i + 1);
                    arr[i + 1]=  arr.ElementAt(i);
                    j = i;
                    while (j > 0 && temp < arr.ElementAt(j - 1))
                    {
                        arr[j]= arr.ElementAt(j - 1);
                        j--;
                    }
                    arr[j] =  temp;
                }
            }
            return arr;
        }
    }
}
