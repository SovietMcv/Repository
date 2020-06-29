using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TrueFalseNew.Models;

namespace TrueFalseNew.Models
{
    [Serializable]
    class TrueFalse
    {
        public int CorrectAnswerCount { get; set; } = 0;
        public string CurrentDisplayedQuestion { get; set; }
        public bool CurrentTrueFalse { get; set; }
        public int QuestionsCount { get; set; } = 1;

        QuestionsDataBase q = new QuestionsDataBase();
        public TrueFalse()
        {
            q.LoadData();
        }
        public void GetStarted()
        {
            CurrentDisplayedQuestion = q.ql[0].Question;
            CurrentTrueFalse = q.ql[0].TrueFalse;
        }
        public bool ChangeQuestion()
        {
            if (QuestionsCount < q.ql.Count)
            {
                CurrentDisplayedQuestion = q.ql[QuestionsCount].Question;
                CurrentTrueFalse = q.ql[QuestionsCount].TrueFalse;
                QuestionsCount++;
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckAnswer(bool answer)
        {
            CorrectAnswerCount += answer == CurrentTrueFalse ? 1 : 0;
            bool res = ChangeQuestion();
            return res;
        }
    }
}