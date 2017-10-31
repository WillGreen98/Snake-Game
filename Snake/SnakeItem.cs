using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class SnakeItem
    {

        Image _Block;
        public int _x, _y, _h, _w;
        int speed = 30;

        public SnakeItem(Image block, int x, int y)
        {
            _x = x;
            _y = y;
            _h = 30;
            _w = 30;
            _Block = block;

        }

        public void draw(Graphics g)
        {
            g.DrawImage(_Block, Rectangle);
            g.DrawRectangle(Pens.Black, Rectangle);
        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(_x, _y, _w, _h);
            }
        }
        public void MoveUp()
        {
            _y -= speed;
        }
        public void MoveDown()
        {
            _y += speed;
        }
        public void MoveLeft()
        {
            _x -= speed;
        }
        public void MoveRight()
        {
            _x += speed;
        }
        public int Top
        {
            get
            {
                return _y;
            }
        }
        public int Bottom
        {
            get
            {
                return _y + _h;
            }
        }
        public int Left
        {
            get
            {
                return _x;
            }
        }
        public int Right
        {
            get
            {
                return _x + _w;
            }
        }
    }
}
