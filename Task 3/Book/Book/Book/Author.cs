using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author : BaseClass
    {        
        public Author (string author)
        {
            field = author;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(FieldProperty);
        }
    }
}
