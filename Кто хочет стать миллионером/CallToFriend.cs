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
    public partial class CallToFriend : Form
    {    
        public CallToFriend()
        {
            InitializeComponent(); 
        }

        private void CallToFriend_Load(object sender, EventArgs e)
        {
            string[] randoms = { "A", "B", "C", "D"};
            Random rnd = new Random();
            int mIndex = rnd.Next(randoms.Length);

            PhraseOfFriend.Text = Convert.ToString("Я думаю, что это ответ под буквой..." + $"{randoms[mIndex]}");
        }


        private void PhraseOfFriend_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
