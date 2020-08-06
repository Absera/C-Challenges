using System;
using System.Collections.Generic;
using System.Linq;

namespace Target_Sum_Indice
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] array = { 1, 1, 3,1, 1, 1 };
            int target = 2;

            // all indices are returned by Indice() as list of list
            // they are iterated below
            foreach(var item in Indice(target, array))
            {
                foreach (var jtem in item)
                {
                    Console.Write(jtem + " ");
                }
                Console.WriteLine("");
            }
        }

        // returns indice like this => [[i, j], [k, m], [o, p]]
        static List<List<int>> Indice(int target, int [] list)
        {
            List<List<int>> Indices = new List<List<int>> { };

            foreach (int i in list)
            {
                foreach (int j in list)
                {
                    int i_index = Array.IndexOf(list, i);
                    int j_index = Array.IndexOf(list, j);
                    // below will make sure indices are not repeted
                    if ((i + j == target) && (count(new List<int> {i_index, j_index}, Indices ) < 1))
                    {
                        Indices.Add(new List<int> {i_index, j_index});
                    }
                }
            }
            return Indices;
        }

        // to count an element in a list of list
        // count([2], [[2], [4], [2]]) returns 2
        static int count(List<int> item, List<List<int>> list)
        {
            int count = 0;
            foreach (var i in list)
            {
                if ( item.OrderBy(m => m).SequenceEqual(i.OrderBy(m => m)))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
