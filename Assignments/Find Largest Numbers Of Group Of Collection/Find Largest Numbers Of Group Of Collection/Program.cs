using System;
using System.Collections;
using System.Collections.Generic;


namespace Find_Largest_Numbers_Of_Group_Of_Collection
{
     class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list1 = new List<List<int>>()
            {
                new List<int>(){67,100,23},
                new List<int>(){80,99,750,99},
                new List<int>(){888,333,9898}
             
            };

            List<int> findLargest = FindLargest(list1); 

            Console.Write("List of largest numbers = (");
            foreach (var item in findLargest)
                Console.Write(item + ", ");
            Console.Write(")");
            Console.ReadKey();



        }
       public static List<int> FindLargest(List<List<int>>numbers)
       {
            List<int> resultsList= new List<int>();
            foreach(List<int> list in numbers)
            {
                if (list.Count > 0)
                {
                    list.Sort();
                    resultsList.Add(list[list.Count - 1]);
                }
            }
            return resultsList;


       }
    }
}
