using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class StudyNullables
    {

       

        public void add(int? a,int? b)
        {
            Console.WriteLine("Addition is "+ (a.Value + b.Value));
        }

        public void nullChecks(int? a, int? b) 
        {
           string aHasValue = a.HasValue?"Yes":"No";
           string bHasValue = b.HasValue?"Yes":"No";

           Console.WriteLine("Is A  having value : {0} ", aHasValue);
           Console.WriteLine("Is B having value  : {0} ", bHasValue);  
        }

        static void Main(string[] args)
        {

            StudyNullables s = new StudyNullables();
            int? a=9;
            int? b = null;

            s.nullChecks(a, b);

            Console.WriteLine("Checking if b null. Assigning value if null using null coalescing operator");
            b = b ?? 10;

            s.add(a, b);

        }
    }
}
