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
        private int speed,m=0;
        private Point position;
        Image image = Resource1.Minoriko;
        Rectangle[,] trimRects = new Rectangle[4, 3];
        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private bool isMovingLeft = false;
        private bool isMovingRight = false;

        public jiki(int x,int y) //x:フォームの幅、y:フォームの高さ
        {
            speed = 10;
            position = new Point(x, y);
            int width = image.Width / trimRects.GetLength(0), height = image.Height / trimRects.GetLength(1);
            for (int i = 0; i < trimRects.GetLength(0); i++) for (int j = 0; j < trimRects.GetLength(1); j++)
                    trimRects[i, j] = new Rectangle(i * width, j * height, width, height);
        }

        public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                isMovingDown = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                isMovingRight = true;
                m = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = true;
                m = 2;
            }
            
        }

        public void Stop(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                isMovingDown = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
                m = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
                m = 0;
            }
            
            
        }

        // ゲームの更新処理
        public void UpdateGame()
        {
            // 移動処理の実行
            if (isMovingUp)
            {
                position.Y -= speed;
            }
            if (isMovingDown)
            {
                position.Y += speed;
            }
            if (isMovingLeft)
            {
                position.X -= speed;
            }
            if (isMovingRight)
            {
                position.X += speed;
            }
        }

        //フォームの原点(0,0)は左上隅 下向きにy軸がある(?)下に行けば行くほどプラスか
        public void LimitOfRange(int right, int bottom)//yは0~-sizeの範囲
        {
            if (this.position.X > (right-500))
            {
                this.position.X = right-500;
            }
            if (this.position.X < 0)
            {
                this.position.X = 0;
            }
            if (this.position.Y<0)
            {
                this.position.Y = 0;
            }
            if (this.position.Y > bottom-50)
            {
                this.position.Y = bottom-50;
            }
        }




        public void Draw(int time,PaintEventArgs e)
        {
            var n = (time / 10) % trimRects.GetLength(0);
            e.Graphics.DrawImage(image, new Rectangle(position.X, position.Y, 50, 50), trimRects[n, m], GraphicsUnit.Pixel);
        }


    }
}
