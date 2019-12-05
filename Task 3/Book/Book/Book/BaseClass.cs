using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BaseClass
    {
        public string Field { get; set ; }
        public virtual ConsoleColor FontColor { get; set; }

        public BaseClass(string field)
        {
            this.Field = field;
        }
        public virtual void Show ()
        {
            
        }
    }
}
