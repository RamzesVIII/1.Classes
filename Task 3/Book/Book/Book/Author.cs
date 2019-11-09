using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author
    {
        string author;
        string AuthorProperty
        { get {return author; } set { author = value; } }

        public Author (string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(AuthorProperty);
        }
    }
}
