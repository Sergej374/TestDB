using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestsDB
{
    public class Test
    {
        public int CreatorsID { get; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        public Test(int ID, string Name)
        {
            CreatorsID = ID;
            this.Name = Name;
        }

        public int MeasureAccuracy(string[][] answers)
        {
            int counter = 0;
            for(int i = 0; i < Questions.Count; i++)
            {
                counter += Questions[i].CheckAnswers(answers[i]);
            }
            return (int)((float)counter / (float)Questions.Count);
        }
    }
}
