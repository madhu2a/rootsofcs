using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 5, 6, 8, 13, 45, 65, 121, 123, 163, 245, 334 };
            int target = 123;
            BinarySearchTree bst = new BinarySearchTree();

            var result = bst.FindElement(data, target) ? "Found element" : "Not found";

            Console.WriteLine(result);
        }
    }
}
