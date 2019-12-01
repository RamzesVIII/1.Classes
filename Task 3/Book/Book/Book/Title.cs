using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Title : BaseClass
    {
        public Title(string title)
        {
            field = title;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FieldProperty);
        }
    }
}
