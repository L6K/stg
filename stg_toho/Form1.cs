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
    public partial class Form1 : Form
    {
        
        
        int time = 0,m;
        jiki jiki = new jiki();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jiki.MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                jiki.MoveDown();
            }
            if (e.KeyCode == Keys.Left)
            {
                jiki.MoveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                jiki.MoveRight();
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            jiki.Draw(time,e);   
        }
    }
}