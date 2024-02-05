using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    //rotate arr
    public class Class1
    {
        public int[] rotate(int[] arr,int pivot)
        {  
            int[] newarr= new int[arr.Length];
            int count = 0;
            /*
            if (count < pivot)
            {
                for(int i = arr.Length - 1; i >= 0; i--)
                {
                    newarr[count++] = arr[i];
                }
            }
            else
            {
                for(int i = count; i < arr.Length; i++)
                {
                    newarr[i] = arr[i];
                }
            }*/
            for (int i = 0; i < pivot; i++)
            {
                int temp = arr[(arr.Length - 1) - i - pivot];
                Console.WriteLine(temp+" "+ newarr[arr.Length - i - 1]+" "+ ((arr.Length - 1) - i - pivot));
                newarr[arr.Length - 1 - i - pivot] = arr[arr.Length - i - 1];
                newarr[arr.Length - i - 1] = temp;
            }
            return newarr;





        }
        static void Main()
        {
            int[] arr = [30, 20, 10, 40, 80, 60];
            int pivot = 3;
            
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Class1 obj=new Class1();

            int[] newarr = obj.rotate(arr,pivot);

            foreach(int i in newarr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
