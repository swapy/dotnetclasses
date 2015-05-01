using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public delegate void execute(int a, int b);
    class WorkingWithDelegates
    {
    
        
        public void add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers {0} and {1} is {2} ", a, b, a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction of two numbers {0} and {1} is {2} ", a, b, a - b);
        }

        public void mul(int a, int b)
        {
            Console.WriteLine("Multiplication of two numbers {0} and {1} is {2} ", a, b, a * b);

        }

        public void div(int a, int b)
        {
            Console.WriteLine("Division of two numbers {0} and {1} is {2} ", a, b, a / b);
        }

        public static void Main(string[] args)
        {
            WorkingWithDelegates w = new WorkingWithDelegates();
            
            //delegate 1
            execute e1 = new execute(w.add);
            e1 += w.sub; // directly add method
            e1 += new execute(w.mul); //create new delegate then combine
            e1 += new execute(w.div); // create new delegate then combine
          //  e1(3,5); // execute delegate


            // an Math power operation 
            e1 += delegate(int a,int b)
            {
                Console.WriteLine("{0} ^ {1} is {2} ",a,b,Math.Pow(a,b));
            };

            e1(3, 5); // execute delegate
        }
    }
}
