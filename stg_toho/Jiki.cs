using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stg_toho
{
    class jiki
    {
        private int speed;
        private Point position;
        Image image = Resource1.Minoriko;
        Rectangle[,] trimRects = new Rectangle[4, 3];

        public jiki()
        {
            speed = 10;
            position = new Point(0, 0);
            int width = image.Width / trimRects.GetLength(0), height = image.Height / trimRects.GetLength(1);
            for (int i = 0; i < trimRects.GetLength(0); i++) for (int j = 0; j < trimRects.GetLength(1); j++)
                    trimRects[i, j] = new Rectangle(i * width, j * height, width, height);
        }

        public void MoveUp()
        {
            position.Y -= speed;
        }

        public void MoveDown()
        {
            position.Y += speed;
        }

        public void MoveRight()
        {
            position.X += speed;
        }

        public void MoveLeft()
        {
            position.X -= speed;
        }



        public void Draw(int time,PaintEventArgs e)
        {
            var n = (time / 10) % trimRects.GetLength(0);
            var m = (time / 100) % trimRects.GetLength(1);
            e.Graphics.DrawImage(image, new Rectangle(position.X, position.Y, 50, 50), trimRects[n, m], GraphicsUnit.Pixel);
        }


    }
}
