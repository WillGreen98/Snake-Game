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
    public partial class game_Window : Form
    {
        Fruit Fruit_Item;
        List<SnakeItem> snake_Piece = new List<SnakeItem>();

        int snake_Direction = 0;
        int players_Points = 0;
        int random_X;
        int random_Y;
        int snake_Length = 0;
        bool game_Over = false;
        bool game_Playing = false;
        SnakeItem piece_1, piece_2;
        Random ran_Number = new Random();
        end_Window end_Form = new end_Window();
        public game_Window()
        {
            InitializeComponent();
            snake_Piece.Add(new SnakeItem(Resource1.Grey, 0, 0));
            Fruit_Item = new Fruit(Resource1.Green, 30, 30);
        }

        private void game_Playing_Timer_Tick(object sender, EventArgs e)
        {

            controls_Group_Box.Text = "Controls - Points: " + Convert.ToString(players_Points);
            fruit_Collision();
            move_Snake();
            switch (snake_Direction)
            {
                case 0:
                    snake_Piece[0].MoveRight();
                    break;
                case 1:
                    snake_Piece[0].MoveDown();
                    break;
                case 2:
                    snake_Piece[0].MoveLeft();
                    break;
                case 3:
                    snake_Piece[0].MoveUp();
                    break;
            }
            snake_Collision();
            if (snake_Piece[0].Top < 0 || snake_Piece[0].Left < 0 || snake_Piece[0].Bottom > 600 || snake_Piece[0].Right > 600)
            {
                game_Over = true;
                end_Form.death_Message_Label.Visible = true;
                end_Form.max_Message_Label.Visible = false;
            }
            if (players_Points == 400)
            {
                game_Over = true;
                end_Form.death_Message_Label.Visible = false;
                end_Form.max_Message_Label.Visible = true;
            }
            if (game_Over)
            {
                game_Playing_Timer.Enabled = false;
                this.Hide();
                end_Form.points_Label.Text = "You Got " + players_Points + " Points.";
                end_Form.Show();
            }
            panel1.Refresh();
        }


        private void game_Window_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && snake_Direction != 1) { snake_Direction = 3; }
            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && snake_Direction != 2) { snake_Direction = 0; }
            if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && snake_Direction != 3) { snake_Direction = 1; }
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && snake_Direction != 0) { snake_Direction = 2; }
            if (e.KeyCode == Keys.Space && game_Playing == false && game_Over == false)
            {
                game_Playing = true;
                game_Playing_Timer.Enabled = true;
                controls_Label.Text = "Use WASD or arrow keys to Move, Press X to Quit.";
            }
            if (e.KeyCode == Keys.X)
            {
                game_Playing = false;
                game_Over = true;
                end_Form.death_Message_Label.Visible = true;
                end_Form.max_Message_Label.Visible = false;
            }
        }
        private void fruit_Collision()
        {
            if (snake_Piece[0].Top == Fruit_Item.Top && snake_Piece[0].Left == Fruit_Item.Left)
            {
                snake_Length++;
                snake_Piece.Add(new SnakeItem(Resource1.Black, Fruit_Item._x, Fruit_Item._y));
                Fruit_Item._x = 650;
                Fruit_Item._y = 650;
                players_Points += 1;
                random_X = ran_Number.Next(0, 19);
                random_Y = ran_Number.Next(0, 19);
                random_X *= 30;
                random_Y *= 30;
                Fruit_Item._x = random_X;
                Fruit_Item._y = random_Y;
            }
        }

        private void move_Snake()
        {
            for (int c = snake_Length; c > 0; c--)
            {
                piece_1 = snake_Piece[c];
                piece_2 = snake_Piece[c-1];
                if (c <= snake_Length)
                {
                    piece_1._x = piece_2._x;
                    piece_1._y = piece_2._y;
                }
            }
        }
        private void snake_Collision()
        {
            for (int c = 1; c < snake_Length +1; c++)
            {
                piece_2 = snake_Piece[c];
                if (snake_Piece[0]._x == piece_2._x && snake_Piece[0]._y == piece_2._y)
                {
                    game_Over = true;
                    game_Playing = false;
                    end_Form.death_Message_Label.Visible = true;
                    end_Form.max_Message_Label.Visible = false;
                }
            }
        }

        private void game_Window_Load(object sender, EventArgs e)
        {

        }
        void Painter(object sender, PaintEventArgs e)
        {
            for (int c = 0; c <= snake_Piece.Count -1; c++)
            {
                snake_Piece[c].draw(e.Graphics);
            }
            Fruit_Item.draw(e.Graphics);
        }
    }
}
