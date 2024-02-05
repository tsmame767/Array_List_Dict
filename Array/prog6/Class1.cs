using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6
{
    public class Class1
    {
        public void minmax(int[] arr)  //Swapping the min max in array
        {
            int max = arr[0];
            int min = arr[1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine(min);


            int indexMax = Array.IndexOf(arr, max);
            int indexMin = Array.IndexOf(arr, min);

            arr[indexMin] = max;
            arr[indexMax] = min;

            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
