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
        //Автосвойство словаря
        private Dictionary<int, string> Sides { get; set; } = new Dictionary<int, string>();

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
            
            Console.WriteLine(Perimeter);
            FigureNazivator();
        }
        //Метод, который подписывает получившиеся фигуры
        public void FigureNazivator()
        {
            Sides.Add(3, "Triangle");
            Sides.Add(4, "Quadrangle");
            Sides.Add(5, "Pentagon");

            foreach (KeyValuePair<int, string> keyValue in Sides)
            {

                if (Sides.Keys.Contains(NPoint.Length))
                {
                    
                    if (keyValue.Key == NPoint.Length)
                    {
                        Console.WriteLine(keyValue.Value);
                    }
                }
                else if (!Sides.Keys.Contains(NPoint.Length))
                {
                    Console.WriteLine("Poligon");
                    break;
                }
                
            }
        }
    }




}
