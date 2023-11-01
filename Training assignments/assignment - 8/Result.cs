using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Result : Test
    {
         int totalScore;

        public Result()
        {
            
        }

        public Result(int rn , string name , int score , List<int> marks)
        {
            this.rn = rn;
            this.name = name;
            this.score = score;
            this.marks = marks;
            this.totalMarks = marks.Sum();
            this.totalScore = this.totalMarks + this.score;

        }

        public void GetDetails()
        {
            base.GetDetails();
        }

        public void CalculateScore()
        {
            totalMarks = marks.Sum();
            totalScore = totalMarks + this.score;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"\n\nStudent Name : {name}\nStudent roll number : {rn}\nScore in sports : {score}\n");

            for(int i = 0; i < marks.Count; i++)
            {
                Console.WriteLine($"Marks in subject {i+1} are {marks[i]}");
            }
            
            Console.WriteLine($"\nTotal Marks : {totalMarks}");

            Console.WriteLine($"\nGrand Total : {totalScore}");


        }
    }
}
