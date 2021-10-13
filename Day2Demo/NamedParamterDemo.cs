using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demo
{
    class NamedParamterDemo
    {
        static void DisplayDetails(int rn , string name , string batch, int marks)
        {
            Console.WriteLine("Roll No is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch is " + batch);
            Console.WriteLine("Marks are " + marks);
        }
        static void Main()
        {
            DisplayDetails(10, "Ajay", "B001", 90);
            // Named Parameter
            DisplayDetails(rn: 1, name: "Deepak",
                batch: "B002", marks: 90);
            DisplayDetails(name: "Gagan", marks: 98, batch: "B002", rn: 3);


        }
    }
}
