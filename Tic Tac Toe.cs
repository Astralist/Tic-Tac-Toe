using System;
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

        bool Player1 = true;
        byte turn = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }

        private void vsCPU(object sender, EventArgs e)
        {

        }

        private void vsPlayer(object sender, EventArgs e)
        {

        }
    }
}
