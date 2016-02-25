using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator_GarciaJoel.Iterator;

namespace Iterator_GarciaJoel.Aggregate
{
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
}
