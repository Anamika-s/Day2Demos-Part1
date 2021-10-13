using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class WithoutMethodOverloadingDemo
    {
        static void Add2Numbers(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Add3Numbers(int x, int y , int z)
        {
            Console.WriteLine(x+y+z);
        }
        static void Add4Numbers(int x, int y, int z, int a)
        {
            Console.WriteLine(x + y + z + a);
        }
        static void Add2Floats(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Add2Numbers1Float(int x, int y, float z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main()
        {
            int x = 20, y = 30;
            Add2Numbers(x, y);
            Add3Numbers(1, 2, 3);
        }
    }
}
