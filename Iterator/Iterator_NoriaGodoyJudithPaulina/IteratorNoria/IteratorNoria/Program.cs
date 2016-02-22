using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using IteratorNoria.Aggregate;
//using IteratorNoria.Iterator;

namespace IteratorNoria
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
        }//fin main

        public class TwitterIterator : IIterator
        {
            private string[] Users;
            private int position;

            public TwitterIterator(string[] users)
            {
                this.Users = users;
                position = 0;
            }

            public void First()
            {
                position = 0;
            }

            public string Next()
            {
                return Users[position++];
            }

            public bool IsDone()
            {
                return position >= Users.Length;
            }

            public string CurrentItem()
            {
                return Users[position];
            }
        }

        public interface IIterator
        {
            void First(); // Reset back to first element
            string Next(); // Get next
            bool IsDone(); // End of collection check
            string CurrentItem(); // Get current item
        }


        public class FacebookIterator : IIterator
        {
            private LinkedList<string> Users;
            private int position;

            public FacebookIterator(LinkedList<string> users)
            {
                this.Users = users;
                position = 0;
            }

            public void First()
            {
                position = 0;
            }

            public string Next()
            {
                return Users.ElementAt(position++);
            }

            public bool IsDone()
            {
                return position >= Users.Count;
            }

            public string CurrentItem()
            {
                return Users.ElementAt(position);
            }
        }
        public interface ISocialNetworking
        {
            IIterator CreateIterator();
        }

        public class Twitter : ISocialNetworking
        {
            private string[] Users;

            public Twitter()
            {
                Users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
            }

            public IIterator CreateIterator()
            {
                return new TwitterIterator(Users);
            }
        }

        public class Facebook : ISocialNetworking
        {
            private LinkedList<string> Users;

            public Facebook()
            {
                // Sign up for an facebook account
                Users = new LinkedList<string>();
                Users.AddLast("Mike");
                Users.AddLast("Jason");
                Users.AddLast("Asad");
                Users.AddLast("Sen");
                Users.AddLast("Vish");
                Users.AddLast("Senthu");
            }

            public IIterator CreateIterator()
            {
                return new FacebookIterator(Users);
            }
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