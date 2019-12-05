using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Title : BaseClass
    {
        public override ConsoleColor FontColor
        {
            get { return ConsoleColor.Cyan; }
            set { FontColor = value; }
        }
        public Title(string title) : base (title)
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
