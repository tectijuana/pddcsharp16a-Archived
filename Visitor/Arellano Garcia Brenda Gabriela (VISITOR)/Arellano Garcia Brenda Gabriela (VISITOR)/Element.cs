using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}