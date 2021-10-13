using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class WithoutOutputParametersDemo
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Product(int x, int y)
        {
            return x * y;
        }
        static void Main()
        {
            int res = Add(2, 30);
            Console.WriteLine("Result is " + res);
            res = Subtract(30, 10);
            res = Product(2, 3);
        }
    }
}
