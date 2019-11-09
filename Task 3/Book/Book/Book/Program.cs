using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstbook = new Book("Pushkin", "Farytales", "for kids");

            firstbook.ShowAll();

        }
        
    }
}
