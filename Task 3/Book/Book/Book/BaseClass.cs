using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BaseClass
    {
        protected string field;
        public string FieldProperty => field;
        
        public void Show (ConsoleColor color)
        {
            
            Console.ForegroundColor = color;
            Console.WriteLine(FieldProperty);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
