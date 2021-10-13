using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class OutputParametersDemo
    {
        static void Operations(int x, int y,
            out int add, out int subtract,
            out int product, out float div)
        {
            add = x + y;
            subtract = x - y;
            product = x * y;
            div = x / y;
        }
        static void Main()
        {
            int x = 20, y = 10;
            int add, subtract, product;
            float div;
            Operations(x, y, out add, out subtract, out product, out div);
            Console.WriteLine("Add is " + add);
            Console.WriteLine("Subtraction is " + subtract);
            Console.WriteLine("Product is " + product);
            Console.WriteLine("Quotient is " + div);

        }
    }
}