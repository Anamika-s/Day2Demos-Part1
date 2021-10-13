using System;

namespace Day2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter No1");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter No2");
            y = Convert.ToByte(Console.ReadLine());
            Operation(x, y);

        }
        static void Operation(int x, int y)
        {
            Console.WriteLine(x+y);
            Console.WriteLine(x-y);

        }
    }
}
