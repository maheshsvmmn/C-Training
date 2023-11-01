using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Test : Sports
    {
        protected List<int> marks;
        protected int totalMarks;

        protected Test()
        {
            
        }
        protected Test(List<int> marks)
        {
            this.marks = marks;
        }

        public void GetDetails()
        {
            base.GetDetails();
            marks = new List<int>();
            Console.Write("Enter number of subjects : ");
            int subjects = int.Parse(Console.ReadLine());

            for(int i = 0; i < subjects; i++)
            {
                Console.Write($"Enter marks in subject {i + 1} : ");
                
                    int mark = int.Parse(Console.ReadLine());
                marks.Add(mark);
            }


        }
    }
}
