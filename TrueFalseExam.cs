using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueFalseExam : Exam
    {
        public TrueFalseExam(double time, int number, Question[] q) : base(time, number, q)
        {
        }
        public override void Showexam()
        {
            foreach(var correct in Questions)
            {
                Console.WriteLine($"Question {correct}:right answer: {correct.CorrectAnswer}");
            }
        }
    }
}
