using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
            Console.ReadKey();
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
            Console.ReadKey();
        }
    }

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