using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class prog1
    {
        static void Main()
        {
            int[] arr = { 4, 3, 7, 15, 6 };
            Sort obj = new Sort();
            obj.PrintArr(arr);
            Console.WriteLine("\n");
            arr = obj.bubblesort(arr);
            //obj.PrintArr(arr);
        }
    }
}
