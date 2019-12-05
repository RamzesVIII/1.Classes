using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Content : BaseClass
    {
        public override ConsoleColor FontColor 
        { 
            get { return ConsoleColor.Green; } 
            set { FontColor = value; }
        }
        public Content(string content) : base (content)
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
