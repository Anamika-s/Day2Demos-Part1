using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class MethodOverloadingDemo
    {
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        // The following will not work 
        //static int Add(int x, int y, int z)
        //{
        //    Console.WriteLine(x + y + z);
        //}
        static void Add(int x, int y, int z, int a)
        {
            Console.WriteLine(x + y + z + a);
        }
        static void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(int x, int y, float z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main()
        {
            int x = 20, y = 30;
            Add(1, 2, 3);
            Add(1.2f, 2.7f);
        }
    }
}
