using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    public class Classprog3
    {
        //determine two integers in array sum to a given number

        public void findindex(int key,int[] arr)
        {
            int fi=0,si=0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == key)
                    {
                        Console.WriteLine(arr[fi] + "+" + arr[si] + "=" + key);
                        fi = i;
                        si = j;
                        break;
                    }
                }
            }
            Console.WriteLine(arr[fi] + "+" + arr[si] + "=" + key);
        }


        static void Main()
        {

            int[] arr = [30, 20, 10, 40, 80, 60];
            int key = 70;

            Classprog3 obj = new Classprog3();
           

            obj.findindex(key, arr);

        }
    }

    
}
