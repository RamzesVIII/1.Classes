using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point
    {
        private int x;
        private int y;
        private string field;

        public int X => x;

        public int Y => y;

        public string Field => field;
        

        public Point (int x, int y, string field)
        {
            this.x = x;
            this.y = y;
            this.field = field;
        }
    }
}
