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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gamePlay = new Form1();
            gamePlay.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm setting = new SettingsForm();
            setting.Show();
        }
    }
}
