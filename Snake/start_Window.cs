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
    public partial class start_Form : Form
    {
        public start_Form()
        {
            InitializeComponent();
        }

        private void quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Button_Click(object sender, EventArgs e)
        {
            game_Window game_Form = new game_Window();
            game_Form.Show();
            this.Hide();
        }
    }
}
