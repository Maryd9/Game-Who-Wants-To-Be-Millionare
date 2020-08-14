using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeMillionare
{
    public partial class mainPanel : Form
    {
        public List<Question> questions = new List<Question>();
        public Random rnd = new Random();
        int level = 0;
        public Question currentQuestion;
        bool MistakeRight = false;

        //Sounds
        SoundPlayer falseAnswer = new SoundPlayer("../../sound/False.wav");
        SoundPlayer rightAnswer = new SoundPlayer("../../sound/True.wav");
        SoundPlayer helpOfPeople = new SoundPlayer("../../sound/HelpOfPeople.wav");
        SoundPlayer callToFriend = new SoundPlayer("../../sound/CallToFriend.wav");
        SoundPlayer startNewGame = new SoundPlayer("../../sound/Gong.wav");
        SoundPlayer victory = new SoundPlayer("../../sound/Victory.wav");
        SoundPlayer tips = new SoundPlayer("../../sound/Tips.wav");

        //Game
        public mainPanel()
        {
            InitializeComponent();
            ReadFile();
            startGame();
        }

        //Read file
        private void ReadFile()
        {
            string path = @"Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }

        //Show a question
        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }

        //Go to next level
        protected void NextStep()
        {
            if (level != 15) 
            { 
                Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

                foreach (Button btn in btns)
                   btn.Enabled = true;

                level++;
                currentQuestion = GetQuestion(level);
                ShowQuestion(currentQuestion);
                lstLevel.SelectedIndex = lstLevel.Items.Count - level;
            }

            if (level == 15)
            {
                Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

                foreach (Button btn in btns)
                    btn.Enabled = true;

                victory.Play();

                MessageBox.Show("Поздравляем! Вы выиграли!");
            }
        }

        //Extracting a question
        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }

        //Start
        private void startGame()
        {
            startNewGame.Play();

            level = 0;
            NextStep();
        }

        //Mouse action
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point lastPoint = new Point(e.X, e.Y); ;

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //Right or wrong answer
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()) || MistakeRight)
            {
                rightAnswer.Play();

                MistakeRight = false;
           
                btnAnswerA.BackColor = Color.FromArgb(192, 192, 255);
                btnAnswerB.BackColor = Color.FromArgb(192, 192, 255);
                btnAnswerC.BackColor = Color.FromArgb(192, 192, 255);
                btnAnswerD.BackColor = Color.FromArgb(192, 192, 255);
                
                NextStep();
            }
            else
            {
                //Sound
                falseAnswer.Play();
                
                //Message
                MessageBox.Show("Неверный ответ!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Hide the form with game
                Hide();

                //Open form of main menu
                var f = new mainMenu();
                f.ShowDialog();

            }
        }
            
        //Ability to choose from two answers
        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            //Sound
            tips.Play();

            //Button selection
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());
                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    btns[n].BackColor = Color.FromArgb(220, 220, 255);
                    count++;
                }
            }

            //Action of button
            bntFiftyFifty.Enabled = false;
            this.bntFiftyFifty.BackColor = Color.FromArgb(220, 220, 255);
        }

        //Ability to change a question
        private void changeAnswer_Click(object sender, EventArgs e)
        {
            //Sound
            tips.Play();

            //Change question
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;

            //Action of button
            changeAnswer.Enabled = false;
            this.changeAnswer.BackColor = Color.FromArgb(220, 220, 255);
        }

        //Friend's help
        private void CallToFriend_Click(object sender, EventArgs e)
        {
            //Sound
            callToFriend.Play();

            //Opening new form
            var f = new CallToFriend();
            f.ShowDialog();

            //Action of button
            CallToFriend.Enabled = false;
            this.CallToFriend.BackColor = Color.FromArgb(220, 220, 255);
        }

        //Help of people from the audience
        private void PeoplsHelp_Click(object sender, EventArgs e)
        {
            //Sound
            helpOfPeople.Play();

            //Opening new form
            var f = new HelpOfPeople(Convert.ToString(currentQuestion.RightAnswer));
            f.ShowDialog();

            //Action of button
            PeoplsHelp.Enabled = false;
            this.PeoplsHelp.BackColor = Color.FromArgb(220, 220, 255);
        }

        //The opportunity to make a mistake
        private void Mistake_Click(object sender, EventArgs e)
        {
            //Sound
            tips.Play();

            //Any button is right
            MistakeRight = true;
            Mistake.Enabled = false;
            this.Mistake.BackColor = Color.FromArgb(220, 220, 255);
        }

        private void mainPanel_Close()
        {
            Close();
        }
    }
}

