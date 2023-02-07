using System;

namespace Maximum_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"Maximum number = {Test_Maximum.IntMaxnum(5, 9, 8)}");
            //Console.WriteLine($"Maximum number = {Test_Maximum.floatMaxnum(5.5f, 9.7f, 8.9f)}");
            //Console.WriteLine($"Maximum String = {Test_Maximum.stringMaxnum("A", "b", "C")}");
            Test_Maximum <int> _Maximum = new Test_Maximum<int>();
            Console.WriteLine($"Maximum = {_Maximum.Maximum(4,7,9)}");


        }
    }
}
