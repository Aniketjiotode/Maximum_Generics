using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Maximum_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {     
           Test_Maximum<double> _Maximum = new Test_Maximum<double>();
           Console.WriteLine(_Maximum.Maximum(2.5, 5.5, 7.6, 6.5, 7.9, 9.9));
        }
     
    }
}
