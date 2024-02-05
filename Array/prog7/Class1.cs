using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog7
{
    public class Class1
    {
        public void zero(int[] arr)
        {

            int[] empty = Array.Empty<int>(); // Create an empty array using Array.Empty<T>()


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    empty = empty.Append(arr[i]).ToArray();



                }



            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {

                    empty = empty.Append(arr[i]).ToArray();


                }



            }
            for (int j = 0; j < empty.Length; j++)
            {
                Console.WriteLine(empty[j]);
                arr.Append(empty[j]).ToArray();

            }



        }
    }
