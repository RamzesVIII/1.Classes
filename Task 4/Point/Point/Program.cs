using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляры фигур и вычисляем их периметр

            Console.WriteLine("Введите количество точек фигуры");
            int numpoints = Convert.ToInt32(Console.ReadLine());
            Point[] arr = new Point[numpoints];
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Point - {0}:", i + 1);
                arr[i] = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToString(Console.ReadLine()));
            }

            Figure figure = new Figure(arr);

            figure.PerimeterCalculator();

            

            //Figure triangle = new Figure(new Point(1, 3, "A"), new Point(5, 5, "B"), new Point(9, 3, "C"));
            //triangle.PerimeterCalculator();

            //Console.WriteLine(new string ('-',50));

            //Figure quadrangle = new Figure(new Point(1, 1, "A"), new Point(15, 3, "B"), new Point(11, 8, "C"), new Point(5,4,"D"));
            //quadrangle.PerimeterCalculator();

            //Console.WriteLine(new string('-', 50));

            //Figure pentagon = new Figure(new Point(1, 1, "A"), new Point(15, 1, "B"), new Point(12, 8, "C"), new Point(9, 7, "D"),
            //    new Point(1,2,"E"));
            //pentagon.PerimeterCalculator();

            //Console.WriteLine(new string('-', 50));

            //Figure poligon = new Figure(new Point(1, 1, "A"), new Point(15, 1, "B"), new Point(12, 8, "C"), new Point(9, 7, "D"),
            //    new Point(5, 5, "E"), new Point(1, 2, "F"));
            //poligon.PerimeterCalculator();

            //Console.WriteLine(new string('-', 50));

            //Figure poligon2 = new Figure(new Point(1, 2, "A"), new Point(14, 1, "B"), new Point(10, 8, "C"), new Point(9, 7, "D"),
            //    new Point(5, 5, "E"), new Point(1, 2, "F"));
            //poligon2.PerimeterCalculator();
        }
    }
}
