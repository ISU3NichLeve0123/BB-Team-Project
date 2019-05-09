﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {

        public MenuScreen()
        {
            InitializeComponent();
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen          
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        private void TwoplayerButton_Click(object sender, EventArgs e)
        {
            //Sets 2 Player to true
            GameScreen.Twoplayer = true;
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }
    }
}
