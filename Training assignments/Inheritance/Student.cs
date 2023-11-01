using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Student
    {
        protected int rn;
        protected string name;

        protected Student()
        {

        }

        protected Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
        }

        public void GetDetails()
        {
            Console.Write("Enter Roll Number : ");
            rn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student name : ");
            name = Console.ReadLine();

        }
    }
}
