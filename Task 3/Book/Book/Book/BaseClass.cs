using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BaseClass
    {
        protected string field;
        internal string FieldProperty => field;
        
        public virtual void Show ()
        {
            Console.WriteLine(field);
        }
    }
}
