using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Author : BaseClass
    {
        public override ConsoleColor FontColor => ConsoleColor.Magenta;
        
        public Author (string author) : base (author)
        {
            
        }

        public override void Show() 
        {
            base.Show();
        }

    }
}
