using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5
{
    public class Class1
    {
        public int findmax(int[] nums)
        {
            int max = nums[0];
            foreach(int i in nums)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main()
        {
            int[] arr = [30, 20, 10, 40, 80, 60];
            Class1 obj = new Class1();
            Console.WriteLine(obj.findmax(arr));

        }
    }
}
