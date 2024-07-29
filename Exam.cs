using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public double TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }

        public Question[] Questions { get; set; }
        public Exam(double time,int number, Question[] q) { TimeOfExam = time; NumberOfQuestion = number; Questions = q; }

        public abstract void Showexam();

    }
}
