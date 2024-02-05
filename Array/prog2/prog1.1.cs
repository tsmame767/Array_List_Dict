using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Bubble Sorting array desc
namespace prog1
    {
        internal class Sort
        {
            public void PrintArr(int[] arr)
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");

                }
                Console.Write("\n");
            }
            public int[] bubblesort(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 1; j < arr.Length - i; j++)
                    {
                        if (arr[j - 1] < arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = temp;

                        }

                    }
                    PrintArr(arr);
                }
                return arr;
            }
        }
    }

