using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithIntegers(18, 9);
        }

        static void WorkingWithIntegers(int a, int b)
        { 
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
