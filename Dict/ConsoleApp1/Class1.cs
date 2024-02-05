using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dict
    {
        Dictionary<string,int> occ = new Dictionary<string,int>();
        string[] strings;

         

        public void wordcount(string[] name )
        {
            
            foreach(string i in name)
            {
                if (occ.ContainsKey(i))
                {
                    occ[i]++;
                }
                else
                {
                    occ[i] = 1;
                }
            }
            foreach(var c in occ)
            {
                string key = c.Key;
                int val = c.Value;
                Console.WriteLine($"{key} : { val}");
            }
        }

        public void charcount(string[] chars)
        {
            foreach(string c in chars)
            {
                if (occ.ContainsKey(c))
                {
                    occ[c]++;
                }
                else
                {
                    occ[c] = 1;
                }
            }

            foreach (var c in occ)
            {
                string key = c.Key;
                int val = c.Value;
                Console.WriteLine($"{key} : {val}");
            }
        }






    }
}
