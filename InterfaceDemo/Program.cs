using System;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           College college = new College();
           college.Details();
           college.StudentDetails();
            ConstructorDemo constructorDemo = new ConstructorDemo("bob",101);
            Console.WriteLine(constructorDemo.Name+" "+constructorDemo.Id);

        }
    }
}
