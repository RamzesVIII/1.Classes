using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Title
    {
        string title;
        string TitleProperty
        { get { return title; } set { title = value; } }

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(TitleProperty);
        }
    }
}
