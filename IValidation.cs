using Mini_Uber;
using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    abstract class IValidation
    {
        // chain of responsibility
        protected DbProxy database;
        public static int counter = 0;
        public abstract void setNext(IValidation nxt);
        public abstract void valid(User ch);
    }
}
