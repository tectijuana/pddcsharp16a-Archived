using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator_GarciaJoel.Iterator;

namespace Iterator_GarciaJoel.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
