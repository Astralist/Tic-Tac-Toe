﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TicTacToe : Form
    {

        bool Player = true;
        byte turn = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Player)
                button.Text = "X";
            else
                button.Text = "O";
                
                Player = !Player;
                
                button.Enabled = false;
                
                Result();
               
        }

        private void Result()
        {
            bool win = false;
            //Vertical Wins
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                win = true;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                win = true;
            if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                win = true;
            
            //Horizontal Wins
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                win = true;
            if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                win = true;
            if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                win = true;
            






            

            
        }

        private void vsCPU(object sender, EventArgs e)
        {

        }

        private void vsPlayer(object sender, EventArgs e)
        {

        }
    }
}
