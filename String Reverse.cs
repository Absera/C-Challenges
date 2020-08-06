using System.Linq;
using static System.Console;

namespace String_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = recurringchar("ABbdfffkj");
            WriteLine(a);

        }

        // a function that reverses a string

        public static string Reverse(string String)
        {
            string reverse = "";
            for (int i = String.Length - 1; i >= 0; i--)
                reverse += String[i];
            return reverse;

        }


        // a function that returns the most occured character from a string
        public static char recurringchar(string str)
        {
            char Char = '0';
            int maxcount = 0;
            foreach (char i in str)
            {
                if (Count(i, str) > maxcount)
                {
                    maxcount = Count(i, str);
                    Char = i;
                }
            }
            return Char;

        }

        // a function to count occurance of a character in a string
        public static int Count(char i, string str)
        {
            int count = 0;
            foreach (char Char in str)
            {
                if ((i.ToString().ToUpper()) == Char.ToString().ToUpper())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
