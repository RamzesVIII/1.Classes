using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Content : BaseClass
    {
        public Content(string content)
        {
            field = content;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FieldProperty);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
