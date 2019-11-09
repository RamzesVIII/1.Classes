using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        int pointA;
        int pointB;
        string field;

        public int PointA
        { get { return pointA; } }
        public int PointB
        { get { return pointB; } }
        public string Field
        { get { return field; } }

        public Point (int pointA, int pointB, string field)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.field = field;
        }
    }
}
