using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Sports : Student
    {
        protected int score;

        protected Sports() { }
        protected Sports(int score) { 
            this.score = score;
        }

        public void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Score in sports : ");
            score = Convert.ToInt32(Console.ReadLine());
        }
    }
}
