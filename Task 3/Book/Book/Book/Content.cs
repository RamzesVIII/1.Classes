using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Content : BaseClass
    {
        public override ConsoleColor FontColor => ConsoleColor.Green;
        
        public Content(string content) : base (content)
        {
            
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
