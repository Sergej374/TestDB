using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestsDB
{
    public class Question
    {
        public string Type { get; }
        public string QuestionText { get; set; } = "";
        public List<string> Options { get; set; } = new List<string>();
        public List<string> RightAnswers { get; set; } = new List<string>();
        public int Accuracy { get; set; }

        public void CheckAnswers(List<string> answers)
        {
            float counter = 0;
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i] == RightAnswers[i])
                {
                    counter++;
                }
            }
            Accuracy = (int)(counter / RightAnswers.Count * 100);
        }

        public Question(string type)
        {
            Type = type;
        }

        public string AnswersToString()
        {
            string output = "";
            for(int i = 0; i < Options.Count; i++)
            {
                output += Options[i] + ">" + RightAnswers[i];
                if (i < Options.Count - 1)
                    output += ";";
            }
            return output;
        }

        public void StringToAnswers(string inputString)
        {
            Options.Clear();
            RightAnswers.Clear();

            if (inputString == "")
                return;

            string[] answerPairs = inputString.Split(new char[] { ';' });

            foreach(string answerPair in answerPairs)
            {
                string option = answerPair.Split(new char[] { '>' })[0];
                string rightAnswer = answerPair.Split(new char[] { '>' })[1];

                Options.Add(option);
                RightAnswers.Add(rightAnswer);
            }
        }
    }
}
