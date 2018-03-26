using ConsoleApp1.controller.sorting;
using ConsoleApp1.model.sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    class Checker
    {
        public List<int> sort(List<int> list, Sorting sort)
        {
     
            switch (sort)
            {
                case Sorting.QUICK:
                    list = QuickSort.quickSort(list);
                    break;

                case Sorting.BUBBLE:
                    list = Bubble.BubbleSort(list);

                    break;
                case Sorting.CHOICE:
                    list = Choice.SelectionSort(list);
                    break;
                case Sorting.MERGER:
                    list = Merger.sortMerge(list);
                    break;
                case Sorting.INSERTION:
                    list = Insertion.insertIntoSort(list);
                    break;
            }

            return list;
        }
    }
}
