using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model.sorting
{
    class Merger
    {
        public static List<int> sortMerge(List<int> arr)
        {
            List<int> arr2 = new List<int>(0);
            List<int> arr1 = new List<int>(0);
            int len = arr.Count;
            if (len < 2) return arr;
            int middle = len / 2;
            int i = 0;
            arr1.Clear();
            arr2.Clear();
            for (; i < middle; i++)
            {
                arr1.Add(arr.ElementAt(i));
            }
            for (; i < len; i++)
            {
                arr2.Add(arr.ElementAt(i));
            }
            return merge(arr1, arr2);
        }



        public static List<int> merge(List<int> arr_1, List<int> arr_2)
        {
            int len_1 = arr_1.Count, len_2 = arr_2.Count;
            int a = 0, b = 0, len = len_1 + len_2; // a, b - счетчики в массивах
            List<int> result = new List<int>(0);
            for (int i = 0; i < len; i++)
            {
                if (b < len_2 && a < len_1)
                {
                    if (arr_1.ElementAt(a) > arr_2.ElementAt(b))
                        result.Add(arr_2.ElementAt(b++));
                    else result.Add(arr_1.ElementAt(a++));
                }
                else if (b < len_2)
                {
                    result.Add(arr_2.ElementAt(b++));
                }
                else
                {
                   
                    result.Add(arr_1.ElementAt(a++));
                }
            }
            return result;
        }
    }
}
