using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrón_de_Diseño__Iterator_CSharp_.Iterator
{
    public interface IIterator
    {
        void First(); // Reset back to first element
        string Next(); // Get next
        bool IsDone(); // End of collection check
        string CurrentItem(); // Get current item
    }
}
