using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class CallByValueCallByRef
    {
        static void Change1(int x)
        {
            x = 100;
            Console.WriteLine("Value of x in Change1" + x); ;
        }
        static void Change2(ref int x)
        {
            x = 200;
            Console.WriteLine("Value of x in Change2" + x); ;

        }
        static void Main()
        {
            int x = 10;
            Console.WriteLine("Value of x in Main" + x); ;
            Change1(x);
            Console.WriteLine("Value of x in Main after Change1 was called" + x);
            Change2(ref x);
            Console.WriteLine("Value of x in Main after Change2 was called" + x);
        }
    }
}
