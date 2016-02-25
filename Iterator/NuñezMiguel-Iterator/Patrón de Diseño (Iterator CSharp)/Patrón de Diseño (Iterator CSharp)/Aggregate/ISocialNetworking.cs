using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Patrón_de_Diseño__Iterator_CSharp_.Iterator;

namespace Patrón_de_Diseño__Iterator_CSharp_.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
