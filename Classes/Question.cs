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

        public int CheckAnswers(string[] answers)
        {
            if (answers == null)
                return 0;

            float counter = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == RightAnswers[i])
                {
                    switch (Type)
                    {
                        case "Single choice":
                            if (answers[i] == "True")
                                return 100;
                            break;
                        case "Multiple choice":
                            if (answers[i] == "True")
                                counter++;
                            break;
                        default:
                            counter++;
                            break;
                    }
                }
            }
            if(Type == "Multiple choice")
            {
                int rightanswers = RightAnswers.FindAll(answer => answer == "True").Count;
                return (int)(counter / rightanswers * 100);
            }
                
            return (int)(counter / RightAnswers.Count * 100);
        }

        public Question(string type)
        {
            Type = type;
        }

        public string AnswersToString()
        {
            string output = "";
            for (int i = 0; i < Options.Count; i++)
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

            foreach (string answerPair in answerPairs)
            {
                string option = answerPair.Split(new char[] { '>' })[0];
                string rightAnswer = answerPair.Split(new char[] { '>' })[1];

                Options.Add(option);
                RightAnswers.Add(rightAnswer);
            }
        }
    }
}
