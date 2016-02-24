using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator_GarciaJoel.Iterator
{
    public interface IIterator
    {
        void First(); // Reset back to first element
        string Next(); // Get next
        bool IsDone(); // End of collection check
        string CurrentItem(); // Get current item
    }
}
