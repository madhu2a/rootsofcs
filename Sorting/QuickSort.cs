using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*////////////////////////////////////////////////////////////////////////
 algorithm quicksort(A, lo, hi) is
    if lo < hi then
        p := partition(A, lo, hi)
        quicksort(A, lo, p - 1 )
        quicksort(A, p + 1, hi)

algorithm partition(A, lo, hi) is
    pivot := A[hi]
    i := lo - 1    
    for j := lo to hi - 1 do
        if A[j] < pivot then
            i := i + 1
            swap A[i] with A[j]
    swap A[i + 1] with A[hi]
    return i + 1
////////////////////////////////////////////////////////////////////////*/

/*////////////////////////////////////////////////////////////////////////
Time Complexity: Best: O(n log(n)), Average: O(n log(n)), Worst: O(n^2)
Space Complexity: O(log(n))
////////////////////////////////////////////////////////////////////////*/

namespace Sorting
{
    public class QuickSort
    {
        public static void ChoosePivot(int[] a, int start, int end)
        {
            int mid = start + (end - start) / 2;
            int median = Math.Max(Math.Min(a[start], a[mid]), Math.Min(Math.Max(a[start], a[mid]), a[end - 1]));
            int pivotPos = Array.IndexOf(a, median);
            Swap(a, pivotPos, start);
        }

        public static int Partition(int[] a, int start, int end)
        {
            int pivotPos = start;       //pivot position (index in the array)
            int pivotVal = a[pivotPos]; //the value of the pivot
            int bigStart = start + 1;   //start index of all values greater than the pivot

            for (int curr = start + 1; curr < end; curr++)
            {
                if (a[curr] < pivotVal)
                {
                    Swap(a, curr, bigStart);
                    bigStart++;
                }
            }

            Swap(a, pivotPos, bigStart - 1);
            pivotPos = bigStart - 1;
            return pivotPos;
        }

        public static void DoQuickSort(int[] a, int start, int end)
        {
            if (end - start == 2)
            {
                if (a[start] > a[end - 1])
                    Swap(a, start, end - 1);
            }
            else if (end - start > 1)
            {
                ChoosePivot(a, start, end);
                int pivotPos = Partition(a, start, end);
                DoQuickSort(a, start, pivotPos);
                DoQuickSort(a, pivotPos + 1, end);
            }
        }

        public int[] DoQuickSort(int[] a)
        {
            if (a != null && a.Length > 1)
                DoQuickSort(a, 0, a.Length);
            return a;
        }

        public static void Swap(int[] a, int x, int y)
        {
            int temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
