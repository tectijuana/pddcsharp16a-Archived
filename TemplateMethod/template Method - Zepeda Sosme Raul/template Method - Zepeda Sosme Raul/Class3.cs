﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea...");
            Console.ReadKey();
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
            Console.ReadKey();
        }
    }
}