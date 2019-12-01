using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр класса Rectangle и выводим его площадь и периметр
            Rectangle figure = new Rectangle(5, 20);
            Console.WriteLine("Area = {0}",figure.Area);
            Console.WriteLine("Perimeter = {0}",figure.Perimeter);
        }
    }
}
