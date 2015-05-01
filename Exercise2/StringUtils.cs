
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class StringUtils
    {
        static void Main(string[] args)
        {

            StringUtils s = new StringUtils();
            s.lengthOfIndiviualStrings(args);
            s.lengthOfAllStrings(args);

            string str = "India is my country.";
            char c = 'c';
            Console.WriteLine("String in upper case is " + str.ToUpper());
            Console.WriteLine("String in lower case is " + str.ToLower());
            Console.WriteLine("Number of occourences of {0} are {1}", c, s.findNumberOfOccourences(c, str));
            Console.WriteLine("Reverse of {0} is {1} ", str, s.reverse(str));

        }


        public string reverse(string str)
        {
            char[] characters = str.ToCharArray();
            Array.Reverse(characters); //reverse string here
            return new string(characters);
        }

        public int findNumberOfOccourences(char c, string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    ++count;

            }

            return count;
        }

        public void lengthOfIndiviualStrings(string[] args)
        {
            // length of each string passed
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Length of the {0} th string is {1} ", i, args[i].Length);
            }
        }

        public void lengthOfAllStrings(string[] args)
        {
            string wholeString = null;

            //concat operation
            // length of all strings passed
            for (int i = 0; i < args.Length; i++)
            {
                wholeString = wholeString + args[i];
            }

            Console.WriteLine("Length of the whole string is" + wholeString.Length);
        }



       


    }
}
