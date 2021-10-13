using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class DefaultParametersDemo
    {
        static void SI(int p=20000, int rate=9, int time=5)
        {
            Console.WriteLine((p * rate * time) / 100);
        }

        static void Main()
        {
            SI(10000, 3, 3);
            SI(10000, 3);
            SI(15000);
            SI();
        }
    }
}
