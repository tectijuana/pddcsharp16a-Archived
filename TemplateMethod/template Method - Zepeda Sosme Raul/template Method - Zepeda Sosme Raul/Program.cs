using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea MyTea = new Tea();
            MyTea.PrepareRecipe();
        }
    }
}
