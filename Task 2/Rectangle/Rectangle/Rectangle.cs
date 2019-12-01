using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;

        internal Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Делаем методы privat, т.к. у них есть свойства для чтения
        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator ()
        {
            return  (side1 + side2) * 2;
        }

        //Свойства методов
        internal double Area
        { get { return AreaCalculator(); } }

        internal double Perimeter
        { get { return PerimeterCalculator(); } }

    }
}
