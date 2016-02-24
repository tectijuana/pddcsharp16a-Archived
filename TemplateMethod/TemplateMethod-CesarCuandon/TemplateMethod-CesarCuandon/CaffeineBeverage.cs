using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod_CesarCuandon
{
    public abstract class CaffeineBeverage
    {
        public /*sealed*/ void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water...");
            Console.ReadKey();
        }

        void PourInCup()
        {
            Console.WriteLine("Poring into cup...");
            Console.ReadKey();
        }

    }
}