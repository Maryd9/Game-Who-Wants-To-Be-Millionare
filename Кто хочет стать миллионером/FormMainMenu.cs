using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeMillionare
{
    public partial class mainMenu : Form
    {
        SoundPlayer begin = new SoundPlayer("../../sound/Begin.wav");

        public mainMenu()
        {
            //Sound
            begin.Play();

            //Start FormMainMenu
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Hide FormMainMenu
            this.Hide();

            //Open form of game
            var f = new mainPanel();
            f.ShowDialog();
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
    }
}
