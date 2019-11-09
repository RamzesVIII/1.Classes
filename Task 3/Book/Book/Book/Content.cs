using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Content
    {
        string content;
        string ContentProperty
        { get { return content; } set { content = value; } }

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ContentProperty);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
