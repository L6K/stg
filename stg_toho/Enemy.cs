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
        Image image = Resource1.enemy;
        public Enemy()
        {
            position = new Point(0, 0);
        }
        public void Move(int a)
        {
            //aの値
            //0:上、1:下、2:右、3:左
            a %= 4;
            switch(a)
            {
                case 0:
                    this.position.Y -= speed;

                    break;

                case 1:
                    this.position.Y += speed;

                    break;

                case 2:
                    this.position.X += speed;

                    break;

                case 3:
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
            e.Graphics.DrawImage(image,new Rectangle(this.position.X,this.position.Y,50,50));
        }

        public void Acceleration()
        {
            this.speed += 10;
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
