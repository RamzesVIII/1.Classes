using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Author : BaseClass
    {
        public override ConsoleColor FontColor
        {
            get { return ConsoleColor.Magenta; }
            set { FontColor = value; }
        }
        public Author (string author) : base (author)
        {
            
        }

        public override void Show() 
        {   
            Console.ForegroundColor = FontColor;
            Console.WriteLine(Field);
            Console.ResetColor();
        }

    }
}
