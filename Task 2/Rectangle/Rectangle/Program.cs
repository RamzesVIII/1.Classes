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
            Rectangle figure = new Rectangle(5, 20);
            Console.WriteLine(figure.Area);
            Console.WriteLine(figure.Perimeter);
        }
    }
}
