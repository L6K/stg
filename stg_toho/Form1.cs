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

        Size formSize;
        jiki jiki;
        int time = 0, m;

        public Form1()
        {
            InitializeComponent();
            EndGameButton.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            jiki.UpdateGame();
            jiki.LimitOfRange(this.Right, this.Bottom);
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


        private void EndGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void EnemyAppearanceTime_Tick(object sender, EventArgs e)
        {

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