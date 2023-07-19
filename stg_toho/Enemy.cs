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
    public class Enemy
    {
        private int speed=5;
        private Point position;
        private Size size;
        Image image = Resource1.enemy;
        int a = 50;
        public Enemy(int a)
        {
            this.a = a;
            position = new Point(0, 0);
            size = new Size(a + 50, a + 50);
        }
        public void Move(int a,int right,int bottom)
        {
            //aの値
            //0:上、1:下、2:右、3:左
            a %= 4;
            switch(a)
            {
                case 0:
                    if (this.position.Y < 0)
                    {
                        this.position.Y += speed;
                    }
                    this.position.Y -= speed;

                    break;

                case 1:
                    if (this.position.Y > (bottom-50))
                    {
                        this.position.Y -= speed;
                    }
                    this.position.Y += speed;

                    break;

                case 2:
                    if (this.position.X > (right - 500))
                    {
                        this.position.X -= speed;
                    }
                    this.position.X += speed;

                    break;

                case 3:
                    if (this.position.X < 0)
                    {
                        this.position.X += speed;
                    }
                    this.position.X -= speed;

                    break;

            }

        }

        public void LimitOfRange(int right, int bottom)//yは0~-sizeの範囲
        {
            if (this.position.X > (right - 500))
            {
                this.position.X = right - 500;
            }
            if (this.position.X < 0)
            {
                this.position.X = 0;
            }
            if (this.position.Y < 0)
            {
                this.position.Y = 0;
            }
            if (this.position.Y > bottom - 50)
            {
                this.position.Y = bottom - 50;
            }
        }

        public void Draw(PaintEventArgs e)
        {
            if (this.a > 100)
            {
                this.a = 100;
            }
            e.Graphics.DrawImage(image,new Rectangle(this.position.X,this.position.Y,this.size.Width,this.size.Width));
        }

        public void Acceleration()
        {
            this.speed += 10;
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public Point getPosi()
        {
            return this.position;
        }
        public Size getSize()
        {
            return this.size;
        }

    }



    public class EnemyManager
    {
        private List<Enemy> enemies;

        public EnemyManager()
        {
            enemies = new List<Enemy>();
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // 他のenemy管理に関するメソッドを実装する
        // ...
    }
}
