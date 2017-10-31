using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class end_Window : Form
    {
        public end_Window()
        {
            InitializeComponent();
        }

        private void quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Button_Click(object sender, EventArgs e)
        {
            game_Window gw = new game_Window();
            this.Hide();
            gw.Visible = true;
        }
    }
}
