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
        public List<Question> Questions { get; set; } = new List<Question>();
        public int Accuracy { get; set; }

        public Test(int ID, string Name)
        {
            CreatorsID = ID;
            this.Name = Name;
        }

        public void MeasureAccuracy()
        {
            int counter = 0;
            foreach (Question question in Questions)
            {
                counter += question.Accuracy;
            }
            Accuracy = (int)((float)counter / (float)Questions.Count);
        }
    }
}
