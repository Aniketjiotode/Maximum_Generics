using System;

namespace Maximum_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Maximum number = {Test_Maximum.IntMaxnum(5, 9, 8)}");
            Console.WriteLine($"Maximum number = {Test_Maximum.floatMaxnum(5.5f, 9.7f, 8.9f)}");
        }
    }
}
