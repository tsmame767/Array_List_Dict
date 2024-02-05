using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Class1
    {
        public void List(List<int> list)                   //Adding the elements to list
        {
            int sum = 0;
            foreach (var element in list)
            {
                sum += element;
            }
            Console.WriteLine("sum :"+sum);
        }


    }

    public class Class2                                        //Remove Duplicates From a List
    {
        public void List(List<int> list)
        {
            List<int> uniqueList = new List<int>();
            foreach (var element in list)
            {
                if (!uniqueList.Contains(element))
                {
                    uniqueList.Add(element);
                }
            }
            foreach (var element in uniqueList)
            {
                Console.Write(element);
            }
            Console.WriteLine();

        }
    }

    public class Class3                                           //Check if a list is sorted in ascending order
    {
        public void List(List<int> list)
        {
            bool isSorted = true;
            for (int i = 0; i < (list.Count - 1); i++)
            {
                if (list[i] > list[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            Console.Write("+ list is :"+isSorted+"\n");
        }
    }


    public class Class4
    {
        public void List(List<int> list)                                //Reverse a given list:
        {
            for(int i=list.Count-1; i>=0; i--)
            {
                Console.Write(list[i] + " ");
            }
        }
    }

    public class Class5                                // Merge two lists into a single sorted list
    {
        public void List(List<int> list1, List<int> list2)
        {
            List<int> mergedList = new List<int>(list1);
            foreach (var element in list2)
            {
                int index = 0;
                while (index < mergedList.Count && element > mergedList[index])
                {
                    index++;
                }
                mergedList.Insert(index, element);
            }

            foreach (var element in mergedList)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }

    public class Class6
    {
        public void List(List<int> list)    //List Rotation
        {
            int positionsToRotate = 3;
            for (int i = 0; i < positionsToRotate; i++)
            {
                int lastElement = list[list.Count - 1];
                for (int j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }
                list[0] = lastElement;
            }

            foreach (var element in list)
            {
                Console.Write(element);
            }
            Console.WriteLine();

        }
    }

    public class Class7                 //count occurenece
    {
        public void List(List<int> list)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            foreach (var element in list)
            {
                if (occurrences.ContainsKey(element))
                {
                    occurrences[element]++;
                }
                else
                {
                    occurrences[element] = 1;
                }
            }

        }

    }
}
