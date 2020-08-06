// This code takes an array or list of integers and group them as pair
// sample input = [1, 1, 3, 4, 3, 1, 5, 5, 5, 5, 6, 4 ]
// sample output = item  count  pairs
//                  1       3     1
//                  3       2     1
//                  5       4     2

using System;
using System.Collections.Generic;

namespace First
{
    class MyClass
    {
        static void Main(string [] args)
        {
            
            // this is the array to be grouped
            List<int>  original_array = new List<int> { 1, 1, 3, 4, 3, 1, 5, 5, 5, 5, 6, 4 };
            // array contains unique elements from the original list
            List<int> unique_array = new List<int>{};


            foreach (int i in original_array) 
            {  
                if (count(i, unique_array) < 1)
                {
                    unique_array.Add(i);
                }
                
            }

            Console.WriteLine("\tItem\tCount\tPair(s)");
            foreach (int item in unique_array)
            {
                int c = count(item, original_array);
                int pairs = pair(c);
                Console.WriteLine("\t{0}\t{1}\t{2}", item,c,pairs);
            }


        }

        // takes two arguements item and list
        // returns number of repetition of the item in the list
        // count(3, new List<int> {1, 2, 3, 3, 1, 0}) returns 2
        static int count(int item, List<int> list)
        {
            int count = 0;
            foreach(var i in list)
            {
                if (item == i)
                {
                    count++;
                }
            }

            return count;
        }

        // divides by 2 if the number is even
        // divides the (number -1) by 2 if the number is odd

        static int pair(int num)
        {   
            if (num%2 == 0)
            {
                return num / 2;
            } else
            {
                return (num-1)/2;
            }
        }
    }
}
