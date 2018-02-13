using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTree
    {
        public bool FindElement(int[] tree, int element)
        {
            int left = 0; // left most
            int right = tree.Length; // right most

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (tree[mid] == element)
                {
                    return true;
                }

                if (tree[mid] < element)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}
