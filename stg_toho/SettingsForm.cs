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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.SettingsForm_Load);

        }

        private void FullScreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void returnMenu_Click(object sender, EventArgs e)
        {
            if (FullScreen.Checked)
            {
                Properties.Settings.Default.FullScreen = true;
            }
            else
            {
                Properties.Settings.Default.FullScreen = false;
            }
            Properties.Settings.Default.Save();
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FullScreen)
            {
                FullScreen.Checked = true;
            }
            else
            {
                FullScreen.Checked = false;
            }
        }

    }
}
