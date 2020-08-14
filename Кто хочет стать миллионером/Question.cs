using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeMillionare
{
    public class Question
    {
        public string Text { get; private set; }
        public string[] Answers { get; set; }
        public int RightAnswer { get; set; }
        public int Level { get; set; }
        public Question(string[] s)
        {
            Text = s[0];
            Answers = new string[4];
            for (int i = 0; i < 4; i++)
                Answers[i] = s[i + 1];
            RightAnswer = int.Parse(s[5]);
            Level = int.Parse(s[6]);
        }
    }
}
