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


        int time = 0, m;
        jiki jiki = new jiki();

        public Form1()
        {
            InitializeComponent();
            EndGameButton.Visible = false;
            if (Properties.Settings.Default.FullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            jiki.UpdateGame();
            Invalidate();
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
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}