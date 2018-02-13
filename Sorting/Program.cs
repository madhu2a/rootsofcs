using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 13, 45, 65, 121, 123, 163, 245, 334 };
            QuickSort quickSort = new QuickSort();

            var sortedArray = quickSort.DoQuickSort(arr);
            foreach (int element in sortedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
        }
    }
}
