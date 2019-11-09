using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Figure
    {
        double perimeter;
        string figure;
        Point A, B, C, D, E;
        int counter;

        public Figure (Point a, Point b, Point c)
        {

            this.A = a;
            this.B = b;
            this.C = c;
            figure = "triangle";
            counter = 3;
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            figure = "quadrangle";
            counter = 4;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            figure = "pentagon";
            counter = 5;
        }

        private double LengthSide (Point A, Point B)
        {

            return Math.Sqrt(Math.Abs(B.PointA - A.PointA) ^ 2 + Math.Abs(B.PointB - A.PointB) ^ 2);
        }

        public void PerimeterCalculator ()
        {
            if (counter == 3)
            {

                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(A, C);

                Console.WriteLine( "This figure is {0}, it's perimeter = {1}",figure, perimeter) ;
                
            }
            else if (counter == 4)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(A, D);

                Console.WriteLine("This figure is {0}, it's perimeter = {1}", figure, perimeter);
            }
            else if (counter == 5)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(A, E);

                Console.WriteLine("This figure is {0}, it's perimeter = {1}", figure, perimeter);
            }
        }
    }
}
