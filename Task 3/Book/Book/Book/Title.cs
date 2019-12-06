using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Title : BaseClass
    {
        public override ConsoleColor FontColor => ConsoleColor.Cyan;
        
        public Title(string title) : base (title)
        {
            
        }

        public override void Show()
        {
            base.Show();

        }
    }
}
