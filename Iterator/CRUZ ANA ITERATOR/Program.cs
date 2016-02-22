using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrón_de_Diseño__Iterator_CSharp_.Iterator
{
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
}