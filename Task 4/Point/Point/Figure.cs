using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Figure
    {
        //Массив точек
        Point[] NPoint;

        //Передаем любое количество точек в качестве аргумента
        public Figure(params Point[] points)
        {
            NPoint = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                NPoint[i] = points[i];
            }
        }
        
        //Вычисляем длину прямой между 2-мя точками
        public double LenghSide(int indexpoint1, int indexpoint2)
        {
            return Math.Sqrt((Math.Pow((NPoint[indexpoint2].X - NPoint[indexpoint1].X), 2) + (Math.Pow((NPoint[indexpoint2].Y - NPoint[indexpoint1].Y), 2))));
        }

        //Вычисляем периметр многоугольника
        public void PerimeterCalculator()
        {
            int counter = NPoint.Length;

            double Perimeter = 0;
            for (int i = 0; i < counter; i++)
            {
                int nextpoint = i + 1;
                if (nextpoint == NPoint.Length)
                {
                    nextpoint = 0;
                }
                Perimeter += LenghSide(i, nextpoint);
            }
            if (counter == 3)
            {
                Console.WriteLine("Triangle");
            }
            else if (counter == 4)
            {
                Console.WriteLine("Quadrangle");
            }
            else if (counter == 5)
            {
                Console.WriteLine("Pentagon");
            }
            else
                Console.WriteLine("poligon");

            Console.WriteLine(Perimeter);
        }

    }




}
