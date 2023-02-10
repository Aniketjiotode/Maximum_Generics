using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Maximum_Generics
{
    internal class Test_Maximum <T> where T : IComparable
    {
        public T Maximum(params T[] a)
        {
            Array.Sort(a);
            return a[a.Length-1];
        }
    }
}
