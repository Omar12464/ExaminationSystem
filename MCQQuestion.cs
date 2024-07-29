using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{

    internal class MCQQuestion:Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] AnswerList, Answer correctanswer) :
        base(header, body, mark, AnswerList, correctanswer)
        {
        }
    }
}
