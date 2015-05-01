using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class WorkingWithMathLibraries
    {

        static void Main(string[] args)
        {
         
            WorkingWithMathLibraries w = new WorkingWithMathLibraries();
            //Square
            int side = 4;
            Console.WriteLine("Perimeter of square is {0} and area is  {1}",w.findAreaOfSquare(side),w.findAreaOfSquare(side));

            //Rectangle
            int length = 4;
            int breadth = 5;
            Console.WriteLine("Perimeter of rectangle is {0} and area is  {1}", w.findPerimeterOfRectange(length, breadth), w.findAreaOfRectangle(length, breadth));

            //Circle
            int radius = 4;
            Console.WriteLine("Circumference of circle is {0} and area is  {1}", w.findCircumferenceOfCircle(radius),w.findAreaOfCircle(radius));
        
        
        
        }

        //Square
        public int findPerimeterOfSquare(int lengthOfSide)
        {
            return 4 * lengthOfSide;
        }

        public double findAreaOfSquare(int lengthOfSide)
        {
            return Math.Pow(lengthOfSide, 2);
        }

        //Rectangle
        public int findPerimeterOfRectange(int length , int breadth)
        {
            return 2 * (length + breadth);
        }

        public int findAreaOfRectangle(int length,int breadth)
        {
            return length * breadth;
        }

        //Circle
        public double findCircumferenceOfCircle(float radius) 
        {
            return 2 * Math.PI * radius; 
        }

        public double findAreaOfCircle(float radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }

 
}
