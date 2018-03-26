using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.controller.sorting
{
    class Bubble
    {
        public static List<int> BubbleSort(List<int> arr)
        {
            bool flag;
            for (int i = arr.Count - 1; i > 0; i--)
            {
                flag = false;
                for (int j = 0; j < i; j++)
                {   
                    if (arr.ElementAt(j) > arr.ElementAt(j + 1))
                    {
                     
                        int help = arr.ElementAt(j);
                        
                        arr[j] = arr.ElementAt(j+1);
                        arr[j+1] =  help;

                        flag = true;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            return arr;
        }
    }
}
