using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam:Exam
    {
        public FinalExam(double time, int number, Question[] q) : base(time, number, q)
        {
        }
        public override void Showexam()
        {
            Console.WriteLine("Final Exam");
            foreach(var question in Questions)
            {
                Console.WriteLine(question);
                foreach(var answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine(question.Mark);
            }
        }
    }
}
