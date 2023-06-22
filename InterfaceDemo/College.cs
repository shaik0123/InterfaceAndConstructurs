using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface IStudent
    {
         public void StudentDetails();
    }
    interface ITeacher
    {
        public void Details();
    }
    public class College : IStudent, ITeacher
    {
         public void Details()
                {   
                    Console.WriteLine("Teacher");

                }
        public void StudentDetails()
        {
            Console.WriteLine("Student");

        }
    } 
}
