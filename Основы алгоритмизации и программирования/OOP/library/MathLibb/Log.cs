using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibb
{
    public class Log
    {
        // логическое и
        public bool And(bool a, bool b) => a && b;
        //логическое или
        public bool Or(bool a, bool b) => a || b;
        //логическое не
        public bool Not(bool a) => !a;
        //исключающее или
        public bool Xor(bool a, bool b) => a != b;
        //Импликация (false только если A=true и B=false)
        public bool Implies(bool a, bool b) => !(a && !b);
        //эквивалентность (если равны)
        public bool Equiv(bool a, bool b) => a == b;

    }
}
