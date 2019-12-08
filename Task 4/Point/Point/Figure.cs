using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Figure
    {
        //Массив точек
        Point[] NPoint;

        //Передаем произвольное количество точек в качестве аргумента
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
            double Perimeter = 0;
            for (int i = 0; i < NPoint.Length; i++)
            {
                int nextpoint = i + 1;
                if (nextpoint == NPoint.Length)
                {
                    nextpoint = 0;
                }
                Perimeter += LenghSide(i, nextpoint);
            }

            Dictionary<int, string> sides = new Dictionary<int, string>();
            {
                sides.Add(3, "Triangle");
                sides.Add(4, "Quadrangle");
                sides.Add(5, "Pentagon");
            }
            string figurename ;
            foreach (KeyValuePair<int,string> keyValue in sides)
            {
                
                if (sides.TryGetValue(keyValue.Key, out figurename))
                {
                    if (keyValue.Key == NPoint.Length)
                    {
                        Console.WriteLine(keyValue.Value);
                    }
                }
                else Console.WriteLine("Poligon");
                
            }
          

            Console.WriteLine(Perimeter);
        }

    }




}
