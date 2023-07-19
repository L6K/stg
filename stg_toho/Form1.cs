using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace stg_toho
{
    public partial class Form1 : Form
    {

        Size formSize;
        jiki jiki;
        List<Enemy> enemies = new List<Enemy>();
        Enemy enemy = new Enemy(0);
        int time = 0;
        Random random = new Random();
        int rn = 0;
        int mag=5;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
            EndGameButton.Visible = false;
            enemies.Add(enemy);
            if (Properties.Settings.Default.FullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                formSize = this.Size;


            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                formSize = this.Size;
            }
            jiki = new jiki(formSize.Width/2, formSize.Height/2);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            jiki.Move(e);
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            jiki.Stop(e);
            Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            jiki.Draw(time, e);
            for(int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Draw(e);
            }

           
        }


        private void EndGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                EndGameButton.Visible = true;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Timer系

        private void timer1_Tick(object sender, EventArgs e)
        {

            time++;
            jiki.UpdateGame();
            jiki.LimitOfRange(this.Right, this.Bottom);
            for(int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Move(rn+i, this.Right, this.Bottom);
                atariHantei(enemies[i], jiki);
            }

            Invalidate();
        }

        private void EnemyAppearanceTime_Tick(object sender, EventArgs e)
        {
            index++;
            for (int i=0; i < enemies.Count; i++)
            {
                if (enemies[i].getSpeed() < 50)
                {
                    enemies[i].Acceleration();
                }
                
            }
            if (index > 5) //表示させる敵の上限
            {
                enemies.RemoveAt(0);
            }
            mag+=10;
            Enemy enmy = new Enemy(mag);
            enemies.Add(enmy);
            

        }
        private void ChangeDirection_Tick(object sender, EventArgs e)
        {
            rn = random.Next(4);
        }


        private void atariHantei(Enemy e,jiki j)
        {
            Point eP = e.getPosi();
            Size eS = e.getSize();
            Point jP = j.getMidPosi();
            if (eP.X <= jP.X && jP.X <= eP.X + eS.Width && eP.Y <= jP.Y && jP.Y <= eP.Y + eS.Height)
            {
                label1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}