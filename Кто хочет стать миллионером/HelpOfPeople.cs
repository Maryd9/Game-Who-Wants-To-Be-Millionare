using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeMillionare
{
    public partial class HelpOfPeople : Form
    {

        public Question currentQuestion;
        string rightAnswer;

        public HelpOfPeople(string answer)
        {
            InitializeComponent();            
            rightAnswer = answer;
        }   
        private void HelpOfPeople_Load(object sender, EventArgs e)
        {
            if (rightAnswer == "1") rightAnswer = "A";
            if (rightAnswer == "2") rightAnswer = "B";
            if (rightAnswer == "3") rightAnswer = "C";
            if (rightAnswer == "4") rightAnswer = "D";

            ChoiceOfPeople.Text = Convert.ToString($"Большинство проголосовало за ответ под буквой...{rightAnswer}");
        }
        private void ChoiceOfPeople_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
