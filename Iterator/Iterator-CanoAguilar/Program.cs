using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator.Aggregate;
using iterator.Iterator;

namespace Iterator___Cano_Aguilar
{
    class Program
    {
        static void Main(string[] args)
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            Console.WriteLine("\nFacebook: ");
            PrintUsers(fbIterator);

            Console.WriteLine("\nTwitter: ");
            PrintUsers(twIterator);

            Console.ReadKey();
        }
        public static void PrintUsers(IIterator iterate)
        {
            iterate.First();
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
