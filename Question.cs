using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Question
    {
        public string HeaderOfQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Question(string header, string body,int mark)
        {
            HeaderOfQuestion = header;
            BodyOfQuestion = body;
            Mark = mark;
        }
        public override string ToString()
        {
            return $"Question:{HeaderOfQuestion}\nBody:{BodyOfQuestion}\nMark:{Mark}";
        }
    }
}
